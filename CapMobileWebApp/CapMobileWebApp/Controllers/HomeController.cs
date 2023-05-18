using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using CapMobileWebApp.Models;
using Microsoft.AspNetCore.Identity;
using CapMobileWebApp.Data;
using Microsoft.AspNetCore.Authorization;

namespace CapMobileWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<UserContext> _us;

        public HomeController(ILogger<HomeController> logger, SignInManager<UserContext> us)
        {
            _logger = logger;
            _us = us;
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
