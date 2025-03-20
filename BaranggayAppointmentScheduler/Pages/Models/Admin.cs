using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("Admins")] // Ensure it maps to the correct table
    public class Admin
    {
        [Key]
        [Column("admin_id")] // Check if this column exists
        public int AdminID { get; set; }

        [Required]
        [Column("username")] // Check if your column is named this
        public string Username { get; set; }

        [Required]
        [Column("password_hash")] // Make sure this matches your database column
        public string PasswordHash { get; set; }
    }
}
