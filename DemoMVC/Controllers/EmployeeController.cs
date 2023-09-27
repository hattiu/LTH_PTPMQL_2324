using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string EmployeeId, int Age)
        {
            ViewBag.empthongBao = EmployeeId + "_" + Age;
            return View();
        }

         public IActionResult Create()
        {
            return View();
        }

    }
