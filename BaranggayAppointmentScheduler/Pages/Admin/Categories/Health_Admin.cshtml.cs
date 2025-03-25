using BaranggayAppointmentScheduler.Data;
using BaranggayAppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BaranggayAppointmentScheduler.Pages.Admin.Categories
{
    public class Health_AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Health_AdminModel(ApplicationDbContext context) { _context = context; }

        public List<HealthAppointment> HealthAppointments { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            HealthAppointments = await _context.HealthAppointments
                .Join(_context.Users,
                      appointment => appointment.UserID,
                      user => user.ID,
                      (appointment, user) => new HealthAppointment
                      {
                          ID = appointment.ID,
                          UserID = appointment.UserID,
                          AppointmentDate = appointment.AppointmentDate,
                          AppointmentTime = appointment.AppointmentTime,
                          Status = appointment.Status,
                          UserName = user.FullName
                      })
                .ToListAsync();

            return Page();
        }

    }
}
