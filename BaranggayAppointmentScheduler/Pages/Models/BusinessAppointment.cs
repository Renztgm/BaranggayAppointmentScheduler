using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("business_appointments")]
public class BusinessAppointment
{
    [Key]
    [Column("appointment_id")]
    public int ID { get; set; }

    [Column("user_id")]
    public string UserID { get; set; }

    [Column("appointment_date")]
    public DateTime AppointmentDate { get; set; }
}
