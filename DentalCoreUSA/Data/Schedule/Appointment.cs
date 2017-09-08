using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DentalCoreUSA.Data.Schedule
{
    //model for the appointments
    public class Appointment
    {
        public int appointmentId { get; set; }

        public DateTime beginAppointment { get; set; }
        public DateTime endAppointment { get; set; }
        public Boolean status { get; set; }
        public string notes { get; set; }

        
        public int patientId { get; set; }
        public virtual Patient patient { get; set; }
        
            //public virtual Doctor doctor { get; set; }

            //public virtual Resource resource { get; set; }

        // type of  appointment
        public int visitTypefieldOptionId { get; set; }
        public virtual VisitType visitType { get; set; }


        public int visitStatusfieldOptionId { get; set; }
        public virtual VisitStatus visitStatus { get; set; }

       // public int chairId { get; set; }
        //public virtual Chair chair { get; set; }

    }
}
/** 
    tag: number;
    dateCreated: string;
    dateUpdated: string;*/
