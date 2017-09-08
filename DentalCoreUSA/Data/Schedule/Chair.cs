
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalCoreUSA.Data.Schedule
{
    public class Chair
    {//room or Chair it depends!!
        public Chair()
        {
            appointments = new List<Appointment>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int chairId { get; set; }
        public string chairName { get; set; }
        public string provider { get; set; }

        //public virtual Place  place { get; set; }
        //[JsonIgnore]
        public virtual ICollection<Appointment> appointments { get; set; }
    }
}