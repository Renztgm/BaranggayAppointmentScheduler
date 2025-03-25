using BaranggayAppointmentScheduler.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("report_appointments")]
public class ReportAppointment
{
    [Key]
    [Column("appointment_id")]
    public long ID { get; set; }

    [ForeignKey("User")]
    [Column("user_id")]
    public int UserID { get; set; } // ❌ Change from long to int

    public User User { get; set; }

    [Column("appointment_date")]
    public DateTime AppointmentDate { get; set; }

    [Column("appointment_time")]
    public TimeSpan AppointmentTime { get; set; }

    [Column("service_type")]
    public string ServiceType { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}

