using DentalCoreUSA.Data.Schedule;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalCoreUSA.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<VisitType> VisitType { get; set; }
        public DbSet<VisitStatus> VisitStatus { get; set; }
        //public DbSet<Place> Place { get; set; }
        //***public DbSet<Resource> Resource { get; set; }
        //public DbSet<Chair> Chair { get; set; }
        //public DbSet<State> State { get; set; }

        public DbSet<StaffUser> StaffUser { get; set; }
        public DbSet<ProvidersUser> ProvidersUser { get; set; }
        
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientDemographic> PatientDemographic { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
