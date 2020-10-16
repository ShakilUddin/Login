using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Data;
using Login.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserLogin user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LoginBDConext db = new LoginBDConext();
                    db.Add<UserLogin>(user);
                    db.SaveChanges();
                    TempData["Msg"] = "Data Saved Successfully In Database";

                }
                
            }
            catch (Exception E)
            {
                TempData["Msg"] = "Data Was Not Saved In Database Sucessfully";
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
