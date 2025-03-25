using Microsoft.EntityFrameworkCore;
using BaranggayAppointmentScheduler.Models;
namespace BaranggayAppointmentScheduler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BusinessAppointment> BusinessAppointments { get; set; }
        public DbSet<GeneralAppointment> GeneralAppointments { get; set; }
        public DbSet<HealthAppointment> HealthAppointments { get; set; }
        public DbSet<NonResidentAppointment> NonResidentAppointments { get; set; }
        public DbSet<ReportAppointment> ReportsAppointments { get; set; }
    }
}
