using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
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
        LunchReservation GetByDateWithStudent(DateTime date, int studentId);
        LunchReservation Add(LunchReservation lunchReservation);
        LunchReservation Update(LunchReservation lunchReservation);
        List<LunchReservationDto> GetLunchReservationDetailList();
    }
}
