using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("health_appointments")] // ✅ Correct table name mapping
    public class HealthAppointment
    {
        [Key]
        [Column("appointment_id")] // ✅ Ensure this matches your DB primary key column
        public int ID { get; set; }

        [Column("user_id")] // ✅ Match with actual column names
        public string UserID { get; set; }

        [Column("appointment_date")] // ✅ Example column
        public DateTime AppointmentDate { get; set; }
    }
}
