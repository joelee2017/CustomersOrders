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

        public ActionResult Orders(string id)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Customers c = dc.Customers.Find(id);
            return PartialView("_OrdersPartial", c.Orders);
        }
    }
}