using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using CapMobileWebApp.Data;
using Microsoft.AspNetCore.Authorization;
using System.Runtime.InteropServices;
using System.Net;

namespace CapMobileWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly SignInManager<UserContext> _us;
            public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

         


        public IActionResult Index()

        {

            return View();
        }

        public async Task<IActionResult> Logout()

        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Access");
        }

    }
}


