using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("reports_appointments")]
public class ReportsAppointment
{
    [Key]
    [Column("appointment_id")]
    public int ID { get; set; }

    [Column("user_id")]
    public string UserID { get; set; }

    [Column("appointment_date")]
    public DateTime AppointmentDate { get; set; }
}
