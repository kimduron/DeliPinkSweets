using Microsoft.AspNetCore.Mvc;

namespace DeliPinkSweets.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
