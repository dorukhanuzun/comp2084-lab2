using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Products> Product = new List<Products>
            {
                new Products {Name = "Laptop"},
                new Products {Name = "Tablet"},
                new Products {Name = "Desktop"}
            };
            ViewData["Products"] = Product;
            return View(Product);
        }


        public ActionResult Details(string productName)
        {
            string message = HttpUtility.HtmlEncode("Your selected product: " + productName);
            ViewData["ProductDetails"] = message;
            return View();
        }
    }
}