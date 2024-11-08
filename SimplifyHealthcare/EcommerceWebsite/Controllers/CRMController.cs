using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM;

namespace EcommerceWebsite.Controllers
{
    public class CRMController : Controller
    {
        // GET: CRM
        public ActionResult Index()
        {
            ICustomerService svc = new CustomerService();
            List<Customer> customers = svc.GetAll();
            return View(customers);
        }
    }
}