using Microsoft.AspNetCore.Mvc;

namespace IsTakipSistemi.Backed.Models
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
