using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class BreakfastMap : EntityTypeConfiguration<Breakfast>
    {
        public BreakfastMap()
        {
            ToTable(@"Breakfast", @"dbo");
            HasKey(x => x.Date);

            Property(x => x.Date).HasColumnName("Date");
            Property(x => x.First).HasColumnName("First");
            Property(x => x.Second).HasColumnName("Second");
            Property(x => x.Third).HasColumnName("Third");
            Property(x => x.Fourth).HasColumnName("Fourth");

        }
    }
}
