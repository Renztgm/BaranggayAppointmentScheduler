using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BaranggayAppointmentScheduler.Models;

[Table("business_appointments")]
public class BusinessAppointment
{
    [Key]
    [Column("appointment_id")]
    public long ID { get; set; }

    [ForeignKey("User")]
    [Column("user_id")]
    public int UserID { get; set; }

    [Column("appointment_date")]
    public DateTime AppointmentDate { get; set; }

    [Column("appointment_time")]
    public TimeSpan AppointmentTime { get; set; }

    [Column("status")]
    public string Status { get; set; }

    public User User { get; set; } // Navigation Property

    [NotMapped] // Since this is not a database column
    public string UserName { get; set; }
}

