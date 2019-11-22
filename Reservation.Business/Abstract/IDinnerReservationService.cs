using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface IDinnerReservationService
    {
        List<DinnerReservation> GetAll();
        DinnerReservation GetById(int id);
        DinnerReservation Add(DinnerReservation dinnerReservation);
        DinnerReservation Update(DinnerReservation dinnerReservation);
        List<DinnerReservationDto> GetDinnerReservationDetailList();
    }
}
