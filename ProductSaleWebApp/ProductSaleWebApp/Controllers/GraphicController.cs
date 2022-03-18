using Microsoft.AspNetCore.Mvc;

namespace ProductSaleWebApp.Controllers
{
    public class GraphicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
