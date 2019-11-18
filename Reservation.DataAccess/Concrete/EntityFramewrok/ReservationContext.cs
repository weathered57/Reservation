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
        public DbSet<BreakfastReservation> BreakfastReservations { get; set; }
        public DbSet<DinnerReservation> DinnerReservations { get; set; }
        public DbSet<LunchReservation> LunchReservations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BreakfastReservationMap());
            modelBuilder.Configurations.Add(new BreakfastMap());
            modelBuilder.Configurations.Add(new DinnerReservationMap());
            modelBuilder.Configurations.Add(new LunchReservationMap());
            modelBuilder.Configurations.Add(new SaloonMap());
            modelBuilder.Configurations.Add(new DinnerMap());
            modelBuilder.Configurations.Add(new LunchMap());
            modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}
