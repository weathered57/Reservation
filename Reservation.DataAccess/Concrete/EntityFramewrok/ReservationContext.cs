using Reservation.DataAccess.Concrete.EntityFramewrok.Mapping;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok
{
    public class ReservationContext : DbContext
    {
        public ReservationContext()
        {
            Database.SetInitializer<ReservationContext>(null);
        }

        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<Lunch> Lunchs { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<FoodReservation> FoodReservations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodReservationMap());
        }
    }
}
