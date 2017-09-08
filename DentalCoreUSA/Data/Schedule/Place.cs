using System.Collections.Generic;

namespace DentalCoreUSA.Data.Schedule
{
    public class Place
    {
        public Place()
        {
            rooms = new List<Chair>();
        }
        public int placeId { get; set; }
        public string address { get; set; }
        public int postalCode { get; set; }
        public string city { get; set; }

        public virtual State state { get; set; }

        public virtual ICollection<Chair> rooms { get; set; }

    }
}