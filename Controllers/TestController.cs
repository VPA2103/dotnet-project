using Microsoft.AspNetCore.Mvc;

namespace SportsStoreWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Chao Mung ban den voi Cua hang the thao! Day la trang Test";
            return View();
        }

        public IActionResult HelloWord()
        {
            return Content("Xin chao tu Action HelloWord cua TestController");
        }

        public IActionResult Welcome(string name = "Khach")
        {
            return Content($"Chao mung {name} den voi trang test");
        }
    }
}