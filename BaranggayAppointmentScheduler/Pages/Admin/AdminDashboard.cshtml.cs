using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BaranggayAppointmentScheduler.Data;

namespace BaranggayAppointmentScheduler.Pages.Admin
{
    public class AdminDashboardModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AdminDashboardModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int GeneralCount { get; set; }
        public int HealthCount { get; set; }
        public int ReportCount { get; set; }
        public int BusinessCount { get; set; }
        public int NonResidentCount { get; set; } // Add this for non-residents
        public int TotalVisitors { get; set; } // ✅ New property

        public async Task OnGet()
        {
            // Query the correct tables from your database
            GeneralCount = await _context.GeneralAppointments.CountAsync();
            HealthCount = await _context.HealthAppointments.CountAsync();
            ReportCount = await _context.ReportsAppointments.CountAsync();
            BusinessCount = await _context.BusinessAppointments.CountAsync();

            TotalVisitors = GeneralCount + HealthCount + ReportCount + BusinessCount + NonResidentCount;
        }
    }
}
