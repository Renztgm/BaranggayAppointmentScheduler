using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("users")] // Ensure it matches your database table
    public class User
    {
        [Key]
        [Column("user_id")] // Matches the database column
        public int ID { get; set; }

        [Required]
        [Column("full_name")]
        [StringLength(150)] // Adjust based on database constraints
        public string FullName { get; set; }

        [Required]
        [Column("email")]
        [StringLength(150)]
        public string Username { get; set; }

        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Column("residency_status")]
        [StringLength(50)] // Example: Resident, Non-Resident
        public string ResidencyStatus { get; set; }

        [Required]
        [Column("password_hash")] // Assuming passwords are stored securely
        public string PasswordHash { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
