using Microsoft.AspNetCore.Mvc;

namespace testfull.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
