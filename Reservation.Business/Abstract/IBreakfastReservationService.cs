using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface IBreakfastReservationService
    {
        List<BreakfastReservation> GetAll();
        BreakfastReservation GetById(int id);
        BreakfastReservation Add(BreakfastReservation foodReservation);
        BreakfastReservation Update(BreakfastReservation foodReservation);
        List<BreakfastReservationDto> GetBreakfastReservaionDetailList();

    }
}
