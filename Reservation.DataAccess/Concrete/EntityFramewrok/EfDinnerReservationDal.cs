using Reservation.DataAccess.Abstract;
using Reservation.DataAccess.Concrete.EntityFramewrok;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete
{
    public class EfDinnerReservationDal : EfEntityRepositoryBase<ReservationContext, DinnerReservation>,IDinnerReservationDal
    {
    }
}
