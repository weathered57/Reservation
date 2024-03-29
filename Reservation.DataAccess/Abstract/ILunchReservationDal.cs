﻿using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Abstract
{
   public interface ILunchReservationDal : IEntityRepository<LunchReservation>
    {
        List<LunchReservationDto> GetLunchReservationDetailList();
    }
}
