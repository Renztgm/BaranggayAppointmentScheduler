using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BaranggayAppointmentScheduler.Data;  // ✅ Ensure this is correct
using BaranggayAppointmentScheduler.Models; // ✅ Add this to reference your models

namespace BaranggayAppointmentScheduler.Pages.Admin
{
    public class AdminLoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AdminLoginModel(ApplicationDbContext context)
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
            var admin = _context.Admins
                .FirstOrDefault(a => a.Username == Username && a.PasswordHash == Password);

            if (admin != null)
            {
                return RedirectToPage("/Admin/AdminDashboard");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                ViewData["ErrorMessage"] = ErrorMessage;
                return Page();
            }
        }
    }
}
