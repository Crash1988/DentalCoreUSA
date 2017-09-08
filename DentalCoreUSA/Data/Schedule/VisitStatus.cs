using Newtonsoft.Json;
using System.Collections.Generic;


namespace DentalCoreUSA.Data.Schedule
{
    public class VisitStatus
    {
        public VisitStatus()
        {
            appointments = new List<Appointment>();
        }
        public int visitStatusId { get; set; }
        public string status { get; set; }//need to check this field
        public string color { get; set; }
        public string description { get; set; }

        public string name { get; set; }
        public int order { get; set; }
        public bool active { get; set; }

        [JsonIgnore]
        public virtual ICollection<Appointment> appointments { get; set; }
    }
}
