using Reservation.Business.Abstract;
using Reservation.DataAccess.Abstract;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Concrete
{
    public class BreakfastReservationManager : IBreakfastReservationService
    {
        private IBreakfastReservationDal _breakfastReservationDal;

        public BreakfastReservationManager(IBreakfastReservationDal foodReservationDal)
        {
            _breakfastReservationDal = foodReservationDal;
        }
        public BreakfastReservation Add(BreakfastReservation foodReservation)
        {
            return _breakfastReservationDal.Add(foodReservation);
        }

        public List<BreakfastReservation> GetAll()
        {
            return _breakfastReservationDal.GetList();
        }

        public BreakfastReservation GetById(int id)
        {
           
            return _breakfastReservationDal.Get(p => p.Id == id);
        }

        public BreakfastReservation Update(BreakfastReservation foodReservation)
        {
            return _breakfastReservationDal.Update(foodReservation);
        }
    }
}
