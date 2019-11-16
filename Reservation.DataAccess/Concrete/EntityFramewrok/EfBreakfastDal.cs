using Reservation.DataAccess.Abstract;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok
{
    public class EfBreakfastDal : EfEntityRepositoryBase<ReservationContext,Breakfast> , IBreakfastDal
    {
    }
}
