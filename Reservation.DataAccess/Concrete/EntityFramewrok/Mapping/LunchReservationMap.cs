using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class LunchReservationMap : EntityTypeConfiguration<LunchReservation>
    {
        public LunchReservationMap()
        {
            ToTable(@"LunchReservations", @"dbo");
            HasKey(x => new { x.Id});

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.ReservationDate).HasColumnName("ReservationDate");
            Property(x => x.StudentId).HasColumnName("StudentId");
            Property(x => x.SaloonId).HasColumnName("SaloonId");
            Property(x => x.CreatedReservation).HasColumnName("CreatedReservation");
        }
    }
}
