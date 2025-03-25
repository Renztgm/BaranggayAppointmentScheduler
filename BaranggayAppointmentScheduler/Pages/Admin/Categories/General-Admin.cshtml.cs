using BaranggayAppointmentScheduler.Data;
using BaranggayAppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaranggayAppointmentScheduler.Pages.Admin.Categories
{
    public class General_AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public General_AdminModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<GeneralAppointmentViewModel> GeneralAppointments { get; set; }
        public List<NonResidentAppointment> NonResidentAppointments { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // Fetch ALL General Appointments and join with users to get the Name
            GeneralAppointments = await _context.GeneralAppointments
                .Join(
                    _context.Users,              // Join with Users table
                    ga => ga.UserID,             // Match general_appointments.user_id
                    u => u.ID,                   // Match users.id
                    (ga, u) => new GeneralAppointmentViewModel
                    {
                        ID = ga.ID,
                        UserID = ga.UserID,
                        AppointmentDate = ga.AppointmentDate,
                        AppointmentTime = ga.AppointmentTime,
                        Status = ga.Status,
                        UserName = u.FullName // Fetch user name
                    })
                .ToListAsync();

            // Fetch ALL fields for Non-Resident Appointments
            NonResidentAppointments = await _context.NonResidentAppointments
                .ToListAsync();

            return Page();
        }
    }

    // ViewModel to hold the joined data
    public class GeneralAppointmentViewModel
    {
        public long ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; } // Retrieved from Users table
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; } // ✅ Include UserName
    }
}
