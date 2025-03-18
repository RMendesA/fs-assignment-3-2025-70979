using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Domain.Entities
{
    class DocPatientAppointment
    {
        public int Id { get; set; }
        public int ApptId  {get; set; }
        public int DocId { get; set; }
        public int PatientId { get; set; }
        public string Status { get; set; }
    }
}
