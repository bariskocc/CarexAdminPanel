using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLteExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminLteExample.Controllers
{
    public class AccountController : Controller
    {
        CarexDBContext db = new CarexDBContext();

        public IActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(Admin admin)
        {
            var _admin = db.Admin.Where(s => s.Email == admin.Email);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.Password == admin.Password).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
    }
}