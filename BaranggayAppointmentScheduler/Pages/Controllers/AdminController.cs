using Microsoft.AspNetCore.Mvc;

namespace Payroll_Test_2.Controllers
{
    public class AdminController : Controller
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "password123"; // Replace with secure authentication

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (Username == AdminUsername && Password == AdminPassword)
            {
                HttpContext.Session.SetString("AdminUser", Username);
                return RedirectToAction("Dashboard");
            }

            ViewData["ErrorMessage"] = "Invalid username or password.";
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("AdminUser") == null)
            {
                return RedirectToAction("Login");
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
