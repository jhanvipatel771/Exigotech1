using Exigotech1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exigotech1.Controllers
{
  
    [Route("Home")]
    public class HomeController : Controller
    {

        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("")]
        [Route("Login")]
        
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email != null && password != null && email.Equals("jhanvi") && password.Equals("19102033"))
            {
                HttpContext.Session.SetString("email", email);
                return View("Dash");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }

        [Route("")]
        [Route("Admin")]
         
        public IActionResult Admin()
        {
            return View();
        }

        [Route("Admin")]
        [HttpPost]
        public IActionResult Admin(string email, string password)
        {
            if (email != null && password != null && email.Equals("kushal") && password.Equals("123456"))
            {
                HttpContext.Session.SetString("email", email);
                return View("Dash");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Admin");
            }
        }
        [Route("Dash")]
        public IActionResult Dash()
        {
            return View();
        }

        [Route("UpdatePassword")]
        public IActionResult UpdatePassword()
        {
            return View();
        }

        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [Route("UpdateProfile")]
        public IActionResult UpdateProfile()
        {
            return View();
        }

        [Route("Onboarding")]
        public IActionResult Onboarding()
        {
            return View();
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("email");
            return View("Index");
        }


    }
}
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Login()
        //{
        //    return View();
        //}

        //public IActionResult forget1()
        //{

        //    return View();
        //}

        //public IActionResult Dash()
        //{
        //    return View();
        //}
        //public IActionResult Admin()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
