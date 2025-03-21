using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaranggayAppointmentScheduler.Models
{
    [Table("non_resident_appointments")] // Map to the correct table
    public class NonResidentAppointment
    {
        [Key]
        [Column("id")]  // Ensure the correct column mapping
        public int Id { get; set; }

        [Column("name")]  // Example column, update as needed
        public string Name { get; set; }

        [Column("appointment_date")]  // Example column, update as needed
        public DateTime AppointmentDate { get; set; }
    }
}
