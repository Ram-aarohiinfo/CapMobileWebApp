using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using CapMobileWebApp.Models;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CapMobileWebApp.Controllers
{
    public class AccessController : Controller
    {

        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index ", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (loginModel.Username == "Admin" && loginModel.Apassword == "yashomkar369"
                )
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, loginModel.Username),

                    new Claim("OtherProperties","Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,

                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);
            }
            return RedirectToAction("Index", "Home ");
            
        }
        //ViewData["ValidateMessage"]= "user not found";
        //return View();
    }
}


//public async Task<IActionResult> OnPostAsync(string returnUrl = null)
//{
//    ReturnUrl = returnUrl;

//    if (ModelState.IsValid)
//    {
//          var user = await AuthenticateUser(Input.Email, Input.Password);
//        if (user == null)
//        {
//            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//            return Page();
//        }

//        var claims = new List<Claim>
//        {
//            new Claim(ClaimTypes.Name, user.Email),
//            new Claim("FullName", user.FullName),
//            new Claim(ClaimTypes.Role, "Administrator"),
//        };

//        var claimsIdentity = new ClaimsIdentity(
//            claims, CookieAuthenticationDefaults.AuthenticationScheme);

//        var authProperties = new AuthenticationProperties
//        {

//        };

//        await HttpContext.SignInAsync(
//            CookieAuthenticationDefaults.AuthenticationScheme,
//            new ClaimsPrincipal(claimsIdentity),
//            authProperties);

//        _logger.LogInformation("User {Email} logged in at {Time}.",
//            user.Email, DateTime.UtcNow);

//        return LocalRedirect(Url.GetLocalUrl(returnUrl));
//    }

//    return Page();
//}



//public async Task OnGetAsync(string returnUrl = null)
//{
//    if (!string.IsNullOrEmpty(ErrorMessage))
//    {
//        ModelState.AddModelError(string.Empty, ErrorMessage);
//    }

//    // Clear the existing external cookie
//    await HttpContext.SignOutAsync(
//        CookieAuthenticationDefaults.AuthenticationScheme);

//    ReturnUrl = returnUrl;
//}
