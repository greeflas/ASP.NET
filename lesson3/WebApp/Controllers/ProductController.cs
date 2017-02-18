using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetProduct()
        {
            return View(new Product() {
                id = 1,
                Category = "Phones",
                Name = "iPhone SE",
                Description = "Cool phone for your lify style",
                Price = 11000
            });
        }
    }
}