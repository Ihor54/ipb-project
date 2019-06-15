using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IPB_Project.Models;

namespace IPB_Project.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            ViewBag.HeaderNeeded = false;
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.HeaderNeeded = true;
            ViewBag.Header = "Contact";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewBag.HeaderNeeded = true;
            ViewBag.Header = "About Us";
            return View();
        }

        public IActionResult Product()
        {
            ViewBag.HeaderNeeded = true;
            ViewBag.Header = "Product";
            return View();
        }
      public IActionResult Services()
        {
            ViewBag.HeaderNeeded = true;
            ViewBag.Header = "Services";
            return View();
        }

      public IActionResult Privacy()
      {
          ViewBag.HeaderNeeded = false;
            return View();
      }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
