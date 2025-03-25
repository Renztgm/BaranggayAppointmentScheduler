using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("nonresident_appointments")]
    public class NonResidentAppointment
    {
        [Key]
        [Column("appointment_id")]
        public long ID { get; set; } // BIGINT

        [Column("guest_id")]
        public int UserID { get; set; } // INT

        [Column("name")]
        public string Name { get; set; } // VARCHAR/NVARCHAR

        [Column("email")]
        public string Email { get; set; } // VARCHAR

        [Column("phone")]
        public string Phone { get; set; } // VARCHAR

        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; } // DATE

        [Column("appointment_time")]
        public TimeSpan AppointmentTime { get; set; } // TIME

        [Column("non_resident_service")]
        public string NonResidentService { get; set; } // VARCHAR

        [Column("status")]
        public string Status { get; set; } // VARCHAR
    }
}
