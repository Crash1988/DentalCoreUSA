using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DentalCoreUSA.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ProvidersUser : ApplicationUser
    {

        public string degree { get; set; }
        public string specialty { get; set; }

        public string deaNumber { get; set; }
        public DateTime deaActive { get; set; }
        public DateTime deaTerm { get; set; }

    }
}
