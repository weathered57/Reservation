using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class SaloonMap : EntityTypeConfiguration<Saloon>
    {
        public SaloonMap()
        {
            ToTable(@"Saloon", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.SaloonName).HasColumnName("SaloonName");

        }
    }
}
