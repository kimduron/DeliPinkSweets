using Microsoft.AspNetCore.Mvc;

namespace DeliPinkSweets.Controllers
{
    public class CakeController : Controller
    {
        public IActionResult Cakes()
        {
            return View();
        }
    }
}
