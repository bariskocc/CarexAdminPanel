using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AdminLteExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var data = db.CustomerDetails.FromSql("select * from CustomerDetails where CustomerId = {0}", id).ToList();
            return View(data);
        }
        public ActionResult AddDetail(int id)
        {
            return View(db.Customer.Where(s => s.CustomerId == id).First());
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
        [HttpGet]
        public ActionResult Create()
        {
            //List<CarBrands> brandList = db.CarBrands.ToList();
            //ViewBag.brandList = new SelectList(brandList, "BrandId", "BrandName");

            List<SelectListItem> markalar = (from i in db.CarBrands.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.BrandName,
                                                 Value = i.BrandId.ToString()
                                             }).ToList();
            ViewBag.markalar = markalar;

            List<SelectListItem> modeller = (from i in db.CarModels.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.ModelName,
                                                 Value = i.ModelId.ToString()
                                             }).ToList();
            ViewBag.modeller = modeller;

            //    if (!ModelState.IsValid)
            //    {
            //        return View("Create");
            //    }
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
                Customer customer = db.Customer.Where(s => s.CustomerId == id).First();
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
            return View(db.Customer.Where(s => s.CustomerId == id).First());
        }
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            Customer d = db.Customer.Where(s => s.CustomerId == customer.CustomerId).First();
            d.CarPlate = customer.CarPlate;
            d.Name = customer.Name;
            d.Phone = customer.Phone;
            d.VehicleType = customer.VehicleType;
            d.Email = customer.Email;
            d.Brand = customer.Brand;
            d.Model = customer.Model;
            db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        public ActionResult UpdateDetail(int id)
        {
            return View(db.CustomerDetails.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateCustomerDetail(CustomerDetails details)
        {
            CustomerDetails d = db.CustomerDetails.Where(s => s.Id == details.Id).First();
            d.Operation = details.Operation;
            d.OperationDate = details.OperationDate;
            d.OperationCost = details.OperationCost;
            db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        [HttpPost]
        public bool DeleteDetail(int id)
        {
            try
            {
                CustomerDetails details = db.CustomerDetails.Where(s => s.Id == id).First();
                db.CustomerDetails.Remove(details);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}