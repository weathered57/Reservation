﻿using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
   public interface ILunchReservationService
    {
        List<LunchReservation> GetAll();
        LunchReservation GetById(int id);
        LunchReservation Add(LunchReservation lunchReservation);
        LunchReservation Update(LunchReservation lunchReservation);
    }
}
