using Microsoft.AspNetCore.Mvc;

namespace DeliPinkSweets.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Cookie()
        {
            return View();
        }
    }
}
