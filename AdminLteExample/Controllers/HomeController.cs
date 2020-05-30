using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLteExample.Models;
using AdminLteExample.ViewModels;

namespace AdminLteExample.Controllers
{
    public class HomeController : Controller
    {
        private CarexDBContext db = new CarexDBContext();
        public IActionResult Index()
        {
            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.customers_count = db.Customer.Count();
            //dashboard.nurses_count = db.Nurses.Count();
            //dashboard.patients_count = db.Patients.Count();
            return View(dashboard);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
