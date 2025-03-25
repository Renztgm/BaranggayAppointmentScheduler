using BaranggayAppointmentScheduler.Data;
using BaranggayAppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BaranggayAppointmentScheduler.Pages.Admin.Categories
{
    public class Business_AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Business_AdminModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public string UserName { get; set; } // ✅ Include UserName
        public List<BusinessAppointment> BusinessAppointments { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            BusinessAppointments = await _context.BusinessAppointments
                .Select(a => new BusinessAppointment
                {
                    ID = a.ID,
                    AppointmentDate = a.AppointmentDate,
                    AppointmentTime = a.AppointmentTime, // Ensure this property exists
                    Status = a.Status,
                    UserName = a.User.FullName // Assuming you have a navigation property "User"
                })
                .ToListAsync();

            return Page();
        }
    }
}
