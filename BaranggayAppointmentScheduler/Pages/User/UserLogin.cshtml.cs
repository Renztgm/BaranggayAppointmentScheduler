using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BaranggayAppointmentScheduler.Data;
using BaranggayAppointmentScheduler.Models;

namespace BaranggayAppointmentScheduler.Pages.User
{
    public class UserLoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UserLoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            ErrorMessage = string.Empty;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Username and password are required.";
                return Page();
            }

            // ? Check if user exists with plain text password
            var user = _context.Users.FirstOrDefault(u => u.Username == Username && u.PasswordHash == Password);

            if (user == null)
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }

            // ? Redirect to User Dashboard
            return RedirectToPage("/User/UserDashboard");
        }
    }
}
