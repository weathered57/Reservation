﻿using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok.Mapping
{
    public class BreakfastReservationMap : EntityTypeConfiguration<BreakfastReservation>
    {
        public BreakfastReservationMap()
        {
            ToTable(@"BreakfastReservations", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.ReservationDate).HasColumnName("ReservationDate");
            Property(x => x.StudentId).HasColumnName("StudentId");
            Property(x => x.SaloonId).HasColumnName("SaloonId");
            Property(x => x.CreatedReservation).HasColumnName("CreatedReservation");
        }
    }
}
