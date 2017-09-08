
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DentalCoreUSA.Data.ScheduleModels
{
    public static class DataSeeder
    {
        // TODO: Move this code when seed data is implemented in EF 7

        /// <summary>
        /// This is a workaround for missing seed data functionality in EF 7.0-rc1
        /// More info: https://github.com/aspnet/EntityFramework/issues/629
        /// </summary>
        /// <param name="app">
        /// An instance that provides the mechanisms to get instance of the database context.
        /// </param>
        public static void SeedData(this IApplicationBuilder app)
        {
            //var db = app.ApplicationServices.GetService<ApplicationDbContext>();

            //State state = new State();
            //state.name = "Wisconsin";
            //state.code = "WI";
            //db.State.Add(state);

            //Place place = new Place();
            //place.address = "4257 n moody ave";
            //place.postalCode = 60634;
            //place.city = "Chicago";
            //place.state = state;
            //db.Place.Add(place);


            //Chair chair = new Chair();
            //chair.chairName = "Room 1";
            //db.Chair.Add(chair);

            //VisitType visitType = new VisitType();
            //visitType.color = "ffffff";
            //visitType.description = "hacerle una placa al paciente";
            //db.VisitType.Add(visitType);

            


            //Appointment appointment = new Appointment();
            //appointment.status = true;
            //appointment.endAppointment = System.Convert.ToDateTime("03/16/2017 10:00");
            //appointment.beginAppointment = System.Convert.ToDateTime("03/16/2017 08:00");
            //appointment.notes = "testing appointment";


            //appointment.visitType = visitType;
            //appointment.chair = chair;
            //db.Appointment.Add(appointment);




            //// TODO: Add seed logic here


            //db.SaveChanges();
        }
    }
}