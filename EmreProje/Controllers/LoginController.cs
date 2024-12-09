using Microsoft.AspNetCore.Mvc;
using EmreProje.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmreProje.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        
        
         
        public LoginController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // Login GET
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Login POST
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Geçersiz giriş denemesi.");
            return View();
        }

        // Kullanıcı Kaydı GET
        [HttpGet]
        public IActionResult KullaniciKayit()
        {
            return View();
        }

        // Kullanıcı Kaydı POST
        [HttpPost]
        public async Task<IActionResult> KullaniciKayit(string email, string password)
        {
            var user = new IdentityUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }

        // Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }
    }
}





/*
namespace EmreProje.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext db;
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login()
        {
        }

        [HttpGet]
        public IActionResult KullaniciKayit()
        {
            return View();
        }
    }
}
*/