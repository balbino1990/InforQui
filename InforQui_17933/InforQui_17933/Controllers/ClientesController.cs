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
            int tamanhoPagina = 5;
            int numeroPagina = pagina ?? 1;     // o número da pagina for nulo, vamos inserir um
            

            return View(db.Produtos.OrderBy(p => p.Nome).ToPagedList(numeroPagina, tamanhoPagina));
        }


        // GET: Clientes/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                // gera um erro que se disse: "Não coloca o 'ID' do produto"
                ModelState.AddModelError("", "Por favor coloca o 'ID' do produto!");
            }
            Produtos produto = db.Produtos.Find(id);
            if (produto == null)
            {
                //vai retornar um 'erro' que se disse: "o produto não existe na tabela"
                ModelState.AddModelError("", "Não existe o produto na tabela!");
            }
            return View(produto);
        }
    }
}
