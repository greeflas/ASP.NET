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
        public ActionResult Index()
        {
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