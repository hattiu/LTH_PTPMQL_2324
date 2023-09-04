using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class GiaiPTController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Index(string soA, string soB, string soC)
    {
        double x1,x2, delta, a=0, b=0, c=0;
        string Ketqua;
        if(!String.IsNullOrEmpty(soA)) a = Convert.ToDouble(soA);
        if(!String.IsNullOrEmpty(soB)) b = Convert.ToDouble(soB);
        if(!String.IsNullOrEmpty(soC)) c = Convert.ToDouble(soC);
        if(a == 0) Ketqua = "khong phai phuong trinh bac 2";
        else
        {
            //tinh delta
            delta = Math.Pow(b,2) - 4*a*c;
            // Giai phuong trinh
            if(delta<0) Ketqua ="Phuong trinh vo nghiem";
            else if(delta==0)
            {
                x1 = -b/(2*a);
                Ketqua ="Phuong trinh co nghiem kep = "+ x1;
            }
            else 
            {
                x1= (-b + Math.Sqrt(delta))/(2*a);
                x2= (-b - Math.Sqrt(delta))/(2*a);
                Ketqua = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
            }
        }
        ViewBag.gpt = Ketqua;
        return View();
    }
}