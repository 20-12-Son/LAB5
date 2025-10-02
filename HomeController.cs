using Microsoft.AspNetCore.Mvc;

namespace LAB5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return RedirectToAction("Create", "Accounts");
        }
    }
}
