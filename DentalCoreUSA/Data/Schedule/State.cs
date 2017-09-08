using System.Collections.Generic;

namespace DentalCoreUSA.Data.Schedule
{
    public class State
    {
        public State()
        {
            places = new List<Place>();
        }
        public int stateId { get; set; }
        public string name { get; set; }
        public string code { get; set; }

        public virtual ICollection<Place> places { get; set; }
    }
}