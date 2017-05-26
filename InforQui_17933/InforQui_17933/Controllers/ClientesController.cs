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
    public class ClientesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //***********************************************************************************************************************
        //      O ação para Index o produto para a tabela
        //***********************************************************************************************************************

        // GET: Clientes
        public ActionResult Index(string Procurar, int? pagina)
        {
            var produtos = from s in db.Produtos
                           select s;
            if (!String.IsNullOrEmpty(Procurar))
            {
                produtos = produtos.Where(s => s.Nome.Contains(Procurar));
            }


            //#########################################################
            //#####Fazer a paginação dos produtos######################

            //atribui para a variavel tamanhoPagina o valor inteiro '5'
            int tamanhoPagina = 5;
            //atribuir para a variavel numeroPagina o numero 'um' se for o parametro da 'pagina' não esta definido
            int numeroPagina = pagina ?? 1;     // o número da pagina for nulo, vamos inserir um
            
            //retorna para o view uma lista de paginas da tabela 'Produtos' que vai ordenar segundo o nome do 'produto' 
            //com 'cinco' produtos e listar começa com 'um'
            return View(db.Produtos.OrderBy(p => p.Nome).ToPagedList(numeroPagina, tamanhoPagina));
        }

        //***********************************************************************************************************************
        //      O ação para Index o produto para a tabela
        //***********************************************************************************************************************

        // GET: Clientes/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            //Se o 'ID' do produto igual a nulo ou quer dizer não colocado
            if (id == null)
            {
                // gera um erro que se disse: "Não coloca o 'ID' do produto"
                ModelState.AddModelError("", "Por favor coloca o 'ID' do produto!");
            }
            // Na tabela 'Produtos' vai gerar um novo objeto 'produto' que vai receber o base de dados 'ApplicationDbContext'
            // com o 'ID' do produto pretendido 
            Produtos produto = db.Produtos.Find(id);
            //Se o produto pretendido não existe na tabela
            if (produto == null)
            {
                //vai retornar um 'erro' que se disse: "o produto não existe na tabela"
                ModelState.AddModelError("", "Não existe o produto na tabela!");
            }
            //retornar para o view da tabela 'Produto'
            return View(produto);
        }
    }
}
