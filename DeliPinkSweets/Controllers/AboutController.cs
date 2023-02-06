using Microsoft.AspNetCore.Mvc;

namespace DeliPinkSweets.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
