using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class FoodReservationMap : EntityTypeConfiguration<FoodReservation>
    {
        public FoodReservationMap()
        {
            ToTable(@"FoodReservations", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.StudentId).HasColumnName("StudentId");
            Property(x => x.SaloonId).HasColumnName("SaloonId");
            Property(x => x.IsBreakfast).HasColumnName("IsBreakfast");
            Property(x => x.IsDinner).HasColumnName("IsDinner");
            Property(x => x.CreatedReservation).HasColumnName("CreatedReservation");
        }
    }
}
