using AutoMapper;
using cosmos.App_Class;
using cosmos.Models;
using cosmos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cosmos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View(Mapper.Map<IEnumerable<CustomerViewModel>>(DbConnection._db.Customers.ToList()));
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


        public ActionResult getProduct()
        {

            ViewModel mv = new ViewModel()
            {
                orders = DbConnection._db.Orders.ToList(),
                products = DbConnection._db.Products.ToList()
            };

            return View(mv);
        }

        public JsonResult getCustomer() {
            List<Customers> customerList = new List<Customers>();

            Customers harun = new Customers()
            {
                Country = "turkey",
                City = "ankara",
                Phone = "5555555555",
                Orders = new List<Orders>() {
                    new Orders
                    {
                        OrderID =2,
                        OrderDate = new DateTime(2018,10,10)

                    }

                }
            };
            customerList.Add(harun);

            Customers tayfun = new Customers()
            {
                Country = "turkey",
                City = "ankara",
                Phone = "5555555555",
                Orders = new List<Orders>() {
                    new Orders
                    {
                        OrderID =3,
                        OrderDate = new DateTime(2018,10,10)

                    }

                }
            };
            customerList.Add(tayfun);
            var customers = DbConnection._db.Customers.ToList();

            List<CustomerViewModel> customerViewModels = customers.Select(c => new CustomerViewModel
            {
                ContactName = c.ContactName,
                CustomerID = c.CustomerID

            }).ToList();



            return Json(customerViewModels, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getSuppliers()
        {

            return View (Mapper.Map<IEnumerable<SupplierViewModel>>(DbConnection._db.Suppliers.ToList()));
        }

    }
}