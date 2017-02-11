using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int x, int y)
        {
            // variant 1
            ViewBag.x = x;
            // variant 2
            ViewData["Y"] = y;

            return View();
        }

        public string Hello()
        {
            return "Hello, World!";
        }

        [NonAction]
        public int Calc()
        {
            return 7;
        }
    }
}