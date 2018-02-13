using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string product)
        {
            ViewBag.product = product;
            ViewBag.Message = "You selected product: " + product;
            return View();
        }
    }
}