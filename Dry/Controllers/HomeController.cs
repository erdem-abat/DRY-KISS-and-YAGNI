using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Dry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int a = 3;
            int b = 4;
            TempData["Result"] = multiplication(a, b);
            return View();
        }

        private int multiplication(int a, int b)
        {
            return a* b; 
        }
    }
}
