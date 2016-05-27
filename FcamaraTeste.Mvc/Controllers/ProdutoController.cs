using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FcamaraTeste.BusinessService;
using FcamaraTeste.Domain;

namespace FcamaraTeste.Mvc.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutoBusinessService _Services = new ProdutoBusinessService();


        // GET: Produto
        public ActionResult Index()
        {
            var ListaProduto = _Services.GetProducts();
            return View(ListaProduto);
        }

       
        // GET: Produto/Details/5
        public PartialViewResult Details(int id)
        {
            Domain.Entidades.Produto _Prod = new Domain.Entidades.Produto();

            if (id != 0)
            {
                 _Prod = _Services.GetProductById(id);
            }
           
            return PartialView("IncluirProduto", _Prod);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create.
        [HttpPost]
        public ActionResult Create(Domain.Entidades.Produto Prod)
        {
            try
            {
                
                _Services.AddProduct(Prod);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Erro");
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
