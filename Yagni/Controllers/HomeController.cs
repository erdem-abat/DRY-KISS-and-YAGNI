using Microsoft.AspNetCore.Mvc;
using Yagni.Models;

namespace Yagni.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user = new User("erdem.abat","password123");
            TempData["user"] = user.GetUser();
            return View();
        }
    }
}
