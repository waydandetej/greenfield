using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EcommerceWebsite.Models;

namespace EcommerceWebsite.Controllers
{
    //action methods
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "abc", Description= "asdf", UnitPrice = 12, Quantity = 10 ,Image="/Images/rose.jpg" });
            products.Add(new Product { Id = 1, Name = "abc", Description = "asdf", UnitPrice = 12, Quantity = 10, Image = "/Images/rose1.jpg" });
            products.Add(new Product { Id = 1, Name = "abc", Description = "asdf", UnitPrice = 12, Quantity = 10, Image = "/Images/rose2.jpg" });


            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}