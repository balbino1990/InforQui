using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using InforQui_17933.Models;

namespace InforQui_17933.Controllers
{
    public class FuncionariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Funcionarios/Index
        public ActionResult Index(int? pagina)
        {
            
            //#########################################################
            //#####Fazer a paginação dos produtos######################
            int tamanhoPagina = 5;
            int numeroPagina = pagina ?? 1;     // o número da pagina for nulo, vamos inserir um

            //vai retornar para o 'VIEW', a lista da tabela 'Produtos' na base de dados 'ApplicationDbContext'
            //e vai ordenar por o 'Nome' do produto
            return View(db.Produtos.OrderBy(p => p.Nome).ToPagedList(numeroPagina, tamanhoPagina));
        }

        // GET: Funcionarios/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            // Se o 'id' do produto igual a nulo
            if (id == null)
            {
                // gera um erro que se disse: "Não coloca o 'ID' do produto"
                ModelState.AddModelError("","Por favor coloca o 'ID' do produto!");
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            // Se este 'id' novo que foi criado, for igual a nulo
            if (produtos == null)
            {
                //vai retornar um 'erro' que se disse: "o produto não existe na tabela"
                ModelState.AddModelError("","Não existe o produto na tabela!");
            }
            //Se não, vai retornar para o 'View' os produto na tabela
            return View(produtos);
        }


        //***********************************************************************************************************************
        //      O ação para Adicionar o produto para a tabela
        //***********************************************************************************************************************

        // GET: funcionarios/Adicionar
        public ActionResult Adicionar()
        {
            // retorna para o 'VIEW' 
            return View();
        }

        // POST: Funcionarios/Adicionar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produto, HttpPostedFileBase file) //HttpPostedFileBase é uma classe do sistema que permite os clientes fazer o upload dos ficheiros
        {

            //determinar o nº (ID) a atribuir a novo 'Produto'
            //criar a variavel que recebe o valor do novo 'produto'

            int novoID = 0;

            try
            {
                //##############################
                //determinar o novo ID

                //O novoID receber a tabela Produtos
                novoID = (from p in db.Produtos 
                          //Ordenar a tabela 'Produto' baseia-se no atributo 'ProdutoID' se forma descedente
                          orderby p.ProdutoID descending
                          //Listar a tabela 'Produtos' com o valor máximo do 'ProdutoID' + 1 
                          select p.ProdutoID).FirstOrDefault() + 1;
            }
            catch (System.Exception)
            {
                // a tabela de 'Produtos' está vazia
                // não sendo possivel devolver o MAX de uma tabela
                // por isso, vou atribuir 'manualmente' o valor do 'noovoID'
                novoID = 1;
            }

            //atribuir o 'novoID' ao objeto produto
            produto.ProdutoID = novoID;


            try
            {
                // Se o modelo ou classe 'Produtos' não tem erro
                if (ModelState.IsValid)
                {
                    // Se o ficheiro que estava upload não igual a nulo
                    if (file != null)
                    {
                        //Vai guardar este ficheiro no servidor baseada neste caminho
                        file.SaveAs(HttpContext.Server.MapPath("~/Content/Imagens/") + file.FileName);
                        //O atributo 'imagem' da tabela 'Produto' vai receber o ficheiro
                        produto.Imagem = file.FileName;
                    }
                    // vai adicionar para a tabela 'Produtos' e o BD 'InforQuiDB'
                    db.Produtos.Add(produto);
                    //vai guardar no BD 'InforQui'
                    db.SaveChanges();
                    //retornar para o 'Index' dos produto
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                // não consigo guardar as alterações 
                //No minimo, preciso de notificar o utilizador que o processo falhou
                ModelState.AddModelError("", "O valor do ID introduzindo é erro!");
                //notificar o 'administrador/programador' que ocorreu este erro
                //fazer: 1º enviar email ao programador a informar da ocorrência do erro
                // 2º ter uma tabela, na BD onde são reportados os erros: 
                //  -data
                //  -método
                //  -controller
                //  -detalhes do erro
            }
            //Retornar para o 'View' dos Produtos
            return View(produto);
        }
        //******************************fim do ação ****************************************************************************


        //***********************************************************************************************************************
        //      O ação para Atualizar o produto para a tabela
        //***********************************************************************************************************************

        // GET: Funcionarios/Atualizar/5
        public ActionResult Atualizar(int? id)
        {
            // Se o 'id' igual a nulo
            if (id == null)
            {
                // gera um erro que se disse: "Não coloca o 'ID' do produto"
                ModelState.AddModelError("", "Por favor coloca o 'ID' do produto!");
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            //Se a tabela 'Produtos' igual a nulo
            if (produtos == null)
            {
                //vai retornar um 'erro' que se disse: "o produto não existe na tabela"
                ModelState.AddModelError("", "Não existe o produto na tabela!");
            }
            //retorna para o 'View' os produto
            return View(produtos);
        }

        // POST: Funcionarios/Atualizar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Esta ActionResult vai ligar para os atributos da tabela 'Produtos'
        public ActionResult Atualizar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produto, HttpPostedFileBase file)
        {
            // Se o modelo ou classe 'Produtos' não tem erro
            if (ModelState.IsValid)
            {
                // Se o ficheiro que estava upload não igual a nulo
                if (file != null)
                {
                    //Vai guardar este ficheiro no servidor baseada neste caminho
                    file.SaveAs(HttpContext.Server.MapPath("~/Content/Imagens/") + file.FileName);
                    //O atributo 'imagem' da tabela 'Produto' vai receber o ficheiro
                    produto.Imagem = file.FileName;
                    db.Entry(file).State = EntityState.Modified;
                }

                db.Entry(produto).State = EntityState.Modified;

                    try
                    {
                        //vai guardar no base de dados 'InforQui', se já não tem erro
                        db.SaveChanges();
                    }
                    catch (System.Exception)
                    {
                        //vai gerar o erro para informar ao utilizador
                        ModelState.AddModelError("","Não consegue adicionar o produto na tabela!");
                        return View(produto);
                    }
                //retornar e redirecionar o ação para o 'View' Index
                return RedirectToAction("Index");
            }
            //retorna para o 'View' da tabela 'Produtos'
            return View(produto);
        }
        //******************************fim do ação ****************************************************************************


        //***********************************************************************************************************************
        //      O ação para Remover o produto para a tabela
        //***********************************************************************************************************************

        // GET: Funcionarios/Remover/5
        public ActionResult Remover(int? id)
        {
            // Se o 'id' do produto igual a nulo
            if (id == null)
            {
                //vai retornar o erro do Http
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            //Se a tabela 'Produtos' igual a nulo
            if (produtos == null)
            {
                // retorna o 'err' do Http
                return HttpNotFound();
            }
            //retorna para o 'View' da tabela 'Produtos'
            return View(produtos);
        }

        // POST: Funcionarios/Remover/5
        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produtos produto = db.Produtos.Find(id);
            try
            {
                //remove do objeto 'db', o produto encontrado na linha anterior
                db.Produtos.Remove(produto);
                //guarda a alteração na tabela 'Produto'
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                //gera uma mensagem 'erro' para informar ao utilizador que ocorreu um erro
                ModelState.AddModelError("", 
                    string.Format("Ocorreu um erro na operação de eliminar o 'dono' com ID {0} - {1}", id, produto.Nome));
                // retorna para o 'view' 
                return View(produto);
            }
           
            return RedirectToAction("Index");
        }
        //******************************fim do ação ****************************************************************************

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
