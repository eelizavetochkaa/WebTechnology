using Microsoft.AspNetCore.Mvc;

namespace WebTechnology.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
