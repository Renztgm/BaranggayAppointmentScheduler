using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    public class User
    {
        [Key]
        [Column("user_id")]
        public int Id { get; set; }

        [Column("email")]
        public string Username { get; set; }

        [Column("password_hash")]
        public string PasswordHash { get; set; } // Store hashed passwords
    }
}