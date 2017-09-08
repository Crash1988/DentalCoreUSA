using Newtonsoft.Json;
using System.Collections.Generic;

namespace DentalCoreUSA.Data.Schedule
{
    public class VisitType
    {
        public VisitType()
        {
            appointments = new List<Appointment>();
        }
        public int visitTypeId { get; set; }
        public string type { get; set; }//check this field
        public string color { get; set; }
        public string description { get; set; }


        public string name { get; set; }
        public int order { get; set; }
        public bool active { get; set; }

        [JsonIgnore]
        public virtual ICollection<Appointment> appointments { get; set; }

    }
}