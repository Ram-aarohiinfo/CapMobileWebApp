using Microsoft.AspNetCore.Mvc;

namespace CapMobileWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login()
        {
            return Redirect("/home");
        }
    }
}
