using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
