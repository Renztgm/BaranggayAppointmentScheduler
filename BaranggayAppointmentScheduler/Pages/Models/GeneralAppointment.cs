using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("general_appointments")]
    public class GeneralAppointment
    {
        [Key]
        [Column("appointment_id")]
        public long ID { get; set; } // BIGINT in SQL

        [Column("user_id")]
        public int UserID { get; set; } // INT in SQL

        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; } // DATE in SQL

        [Column("appointment_time")]
        public TimeSpan AppointmentTime { get; set; } // TIME in SQL

        [Column("status")]
        public string Status { get; set; } // VARCHAR in SQL

        public string UserName { get; set; } // ✅ Include UserName
    }
}
