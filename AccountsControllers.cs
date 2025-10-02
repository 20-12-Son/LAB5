using Microsoft.AspNetCore.Mvc;
using LAB5.Models;

namespace LAB5.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account acc)
        {
            if (ModelState.IsValid)
            {
                return View("Success", acc);
            }
            return View(acc);
        }
    }
}
