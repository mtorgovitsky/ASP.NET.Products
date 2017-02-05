using ASP.NET.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.Products.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ProductsDB pDB = new ProductsDB();
            return View(pDB);
        }

        //public ActionResult PartialViewResult(Product p)
        //{
        //    return PartialView();
        //}
    }
}