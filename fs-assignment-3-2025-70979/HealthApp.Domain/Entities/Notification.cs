using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Domain.Entities
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string UserId { get; set; }  // Link to Identity user
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        [EnumDataType(typeof(NotificationType))]
        public string NotificationType { get; set; }  // AppointmentBooked, AppointmentCancelled, Reminder

        [Required]
        public string Message { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;
    }

    // Enum for Notification Type
    public enum NotificationType
    {
        AppointmentBooked,
        AppointmentCancelled,
        Reminder
    }
}
