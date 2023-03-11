using Microsoft.AspNetCore.Mvc;

namespace WebArchitecture.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
