using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class DinnerReservationMap : EntityTypeConfiguration<DinnerReservation>
    {
        public DinnerReservationMap()
        {
            ToTable(@"DinnerReservations", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.StudentId).HasColumnName("StudentId");
            Property(x => x.SaloonId).HasColumnName("SaloonId");
            Property(x => x.CreatedReservation).HasColumnName("CreatedReservation");
        }
    }
}
