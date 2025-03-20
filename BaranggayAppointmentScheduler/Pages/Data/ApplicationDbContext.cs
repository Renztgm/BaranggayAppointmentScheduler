using Microsoft.EntityFrameworkCore;
using BaranggayAppointmentScheduler.Models; // Ensure the correct namespace for Models

namespace BaranggayAppointmentScheduler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
    }
}
