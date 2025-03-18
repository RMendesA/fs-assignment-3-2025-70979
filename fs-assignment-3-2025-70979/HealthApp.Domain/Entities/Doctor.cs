using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity;

namespace HealthApp.Domain.Entities
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string UserId { get; set; }  // Link to Identity user
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Required]
        [MaxLength(50)]
        public string LicenseNumber { get; set; }

    }
}
