using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class StudentMap:EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable(@"Student", @"dbo");
            HasKey(x => x.SchoolNo);

            Property(x => x.SchoolNo).HasColumnName("SchoolNo");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Second");
            Property(x => x.DepartmentName).HasColumnName("Third");
           
        }
    }
}
