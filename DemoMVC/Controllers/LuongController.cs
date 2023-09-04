using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class LuongController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Index(string luongCB, string heSo, string phuCap)
        {
            double cb =0, hs =0, pc =0, luong = 0;
            string luongNV;
            if(!String.IsNullOrEmpty(luongCB)) cb = Convert.ToDouble(luongCB);
            if(!String.IsNullOrEmpty(heSo)) hs = Convert.ToDouble(heSo);
            if(!String.IsNullOrEmpty(phuCap)) pc = Convert.ToDouble(phuCap);
            luong = cb*hs+pc;
            luongNV = "Lương : " + luong ;
            ViewBag.luong = luongNV;
            return View();
        }
    }
}