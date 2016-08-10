using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UIAbstraction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult Payments()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult ChangeEmail()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }




            
        public IActionResult Error()
        {
            return View();
        }
    }
}
