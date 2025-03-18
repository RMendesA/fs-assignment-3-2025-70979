using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Domain.Entities
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        [Required]
        public Guid DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime AppointmentDateTime { get; set; }

        [Required]
        [EnumDataType(typeof(AppointmentStatus))]
        public string Status { get; set; } = "Pending";  // Pending, Approved, Rejected, Completed, Cancelled

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
    // Enum for Appointment Status
    public enum AppointmentStatus
    {
        Pending,
        Approved,
        Rejected,
        Completed,
        Cancelled
    }
}
