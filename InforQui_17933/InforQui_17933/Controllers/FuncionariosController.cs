using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InforQui_17933.Models;

namespace InforQui_17933.Controllers
{
    public class FuncionariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Funcionarios/Index
        public ActionResult Index()
        {
            //vai retornar para o 'VIEW', a lista da tabela 'Produtos' na base de dados 'InforQui'
            //e vai ordenar por o 'Nome' do produto
            return View(db.Produtos.ToList().OrderBy(d => d.Nome));
        }

        // GET: Funcionarios/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            // Se o 'id' do produto igual a nulo
            if (id == null)
            {
                // retorna um 'erro' do estado Http
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            // Se este 'id' novo que foi criado, for igual a nulo
            if (produtos == null)
            {
                //vai retornar um 'erro' de Http que disse: "não existe"
                return HttpNotFound();
            }
            //Se não, vai retornar para o 'View' os produtos na tabela
            return View(produtos);
        }

        // GET: funcionarios/Adicionar
        public ActionResult Adicionar()
        {
            // retorna para o 'VIEW' 
            return View();
        }

        // POST: Funcionarios/Adicionar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produtos, HttpPostedFileBase file) //HttpPostedFileBase é uma classe do sistema que permite os clientes fazer o upload dos ficheiros
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
                    produtos.Imagem = file.FileName;
                }
                // vai adicionar para a tabela 'Produtos' e o BD 'InforQuiDB'
                db.Produtos.Add(produtos);
                //vai guardar no BD 'InforQui'
                db.SaveChanges();
                //retornar para o 'Index' dos produtos
                return RedirectToAction("Index");
            }
            //Retornar para o 'View' dos Produtos
            return View(produtos);
        }

        // GET: Funcionarios/Atualizar/5
        public ActionResult Atualizar(int? id)
        {
            // Se o 'id' igual a nulo
            if (id == null)
            {
                // vai retornar o 'erro' do Http
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            //Se a tabela 'Produtos' igual a nulo
            if (produtos == null)
            {
                //retorna o 'erro' do Http que disse: 'não existe' o produto na tabela
                return HttpNotFound();
            }
            //retorna para o 'View' os produtos
            return View(produtos);
        }

        // POST: Funcionarios/Atualizar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Esta ActionResult vai ligar para os atributos da tabela 'Produtos'
        public ActionResult Atualizar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produtos, HttpPostedFileBase file)
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
                    produtos.Imagem = file.FileName;
                    db.Entry(file).State = EntityState.Modified;
                }

                //

                db.Entry(produtos).State = EntityState.Modified;
                //vai guardar no base de dados 'InforQui', se já não tem erro
                db.SaveChanges();
                //retornar e redirecionar o ação para o 'View' Index
                return RedirectToAction("Index");
            }
            //retorna para o 'View' da tabela 'Produtos'
            return View(produtos);
        }

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

        // POST: Funcionarios/Apagar/5
        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produtos produtos = db.Produtos.Find(id);
            db.Produtos.Remove(produtos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
