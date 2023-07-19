using Microsoft.AspNetCore.Mvc;
using System;

namespace Kiss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "erdem";
            bool success=false;
            if (name.Contains("d"))
            {
                success=true;
            }
            TempData["success"] = success;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == 'd')
            //    {
            //        TempData["d"] = i;
            //        break;
            //    }
            //}
            return View();
        }
    }
}
