﻿
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catagory;

namespace EcommerceWebsite.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
           IProductService svc = new ProductService();
            List<Product> products = svc.GetAll();

            return View(products);
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

    }
}