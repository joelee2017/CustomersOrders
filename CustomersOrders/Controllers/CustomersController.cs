using CustomersOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersOrders.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            NorthwindEntities dc = new NorthwindEntities();
            ViewBag.Customers = new SelectList(dc.Customers, "CustomerID", "CompanyName");
            return View();
        }
    }
}