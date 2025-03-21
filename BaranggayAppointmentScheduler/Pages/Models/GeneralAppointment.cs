using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("general_appointments")] // Maps to the correct table name in DB
    public class GeneralAppointment
    {
        [Key]
        [Column("appointment_id")]
        public int ID { get; set; }

        [Column("user_id")]
        public string UserID { get; set; }

        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; }
    }
}
