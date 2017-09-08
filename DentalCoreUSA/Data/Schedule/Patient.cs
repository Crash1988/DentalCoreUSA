using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalCoreUSA.Data.Schedule
{
    public class Patient
    {
        public Patient()
        {
            appointments = new List<Appointment>();
        }
        public int patientId { get; set; }
        [Required]
        public int mrn { get; set; }
        [Required]
        [MinLength(3)]
        public string name { get; set; }
        [Required]
        public string lastname { get; set; }

        public string middle_name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        [Required]
        public string primaryphone { get; set; }
        [Required]
        public string email { get; set; }

        public virtual ICollection<Appointment>  appointments { get; set; }
        
    }
}