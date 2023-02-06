using Microsoft.AspNetCore.Mvc;

namespace DeliPinkSweets.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Recipe()
        {
            return View();
        }
    }
}
