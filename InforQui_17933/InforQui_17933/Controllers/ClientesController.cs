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
    public class ClientesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Clientes
        public ActionResult Index(string Procurar)
        {
            var produtos = from s in db.Produtos
                           select s;
            if (!String.IsNullOrEmpty(Procurar))
            {
                produtos = produtos.Where(s => s.Nome.Contains(Procurar));
            }

            return View(produtos.ToList());
        }


        // GET: Clientes/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos produtos = db.Produtos.Find(id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }
    }
}
