using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AdminLteExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdminLteExample.Controllers
{
    public class CustomersController : Controller
    {
        CarexDBContext db = new CarexDBContext();

        public ActionResult Index()
        {
            return View(db.Customer.ToList());
        }
        public ActionResult Details(int id)
        {
            var data = db.CustomerDetails.FromSql("select * from customer_details where customer_id = {0}", id).ToList();
            return View(data);
        }
        public ActionResult AddDetail(int id)
        {
            return View(db.Customer.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult AddDetail(CustomerDetails details)
        {
            db.CustomerDetails.Add(details);
            db.SaveChanges();

            //CustomerDetails cd = db.CustomerDetails.Where(s => s.Id == details.Id).First();
            //cd.CustomerId = details.CustomerId;
            //db.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Customer customer = db.Customer.Where(s => s.Id == id).First();
                db.Customer.Remove(customer);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
        public ActionResult Update(int id)
        {
            return View(db.Customer.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            Customer d = db.Customer.Where(s => s.Id == customer.Id).First();
            d.CarPlate = customer.CarPlate;
            d.Name = customer.Name;
            d.Phone = customer.Phone;
            d.VehicleType = customer.VehicleType;
            d.Email = customer.Email;
            db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
    }
}