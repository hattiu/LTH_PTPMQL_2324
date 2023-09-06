using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(string Name, string DiaChi)
        {
            ViewBag.thongBao = "Xin chao: " + Name +"-"+ DiaChi;
            return View();
        }

    }
}