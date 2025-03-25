using BaranggayAppointmentScheduler.Data;
using BaranggayAppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaranggayAppointmentScheduler.Pages.Admin.Categories
{
    public class Report_AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Report_AdminModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ReportAppointment> ReportAppointments { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            ReportAppointments = await _context.ReportsAppointments
                .Include(a => a.User)
                .Select(a => new ReportAppointment
                {
                    ID = a.ID,
                    UserID = a.UserID,
                    AppointmentDate = a.AppointmentDate,
                    AppointmentTime = a.AppointmentTime,
                    ServiceType = a.ServiceType,
                    Status = a.Status,
                    CreatedAt = a.CreatedAt,
                    User = new Models.User { FullName = a.User.FullName }
                })
                .ToListAsync();

            return Page();
        }
    }
}
