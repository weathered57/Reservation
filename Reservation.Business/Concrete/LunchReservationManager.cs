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
    public class LunchReservationManager : ILunchReservationService
    {
        private ILunchReservationDal _lunchReservationDal;

        public LunchReservationManager(ILunchReservationDal lunchReservationDal)
        {
            _lunchReservationDal = lunchReservationDal;
        }
        public LunchReservation Add(LunchReservation foodReservation)
        {
            return _lunchReservationDal.Add(foodReservation);
        }

        public List<LunchReservation> GetAll()
        {
            return _lunchReservationDal.GetList();
        }

        public LunchReservation GetById(int id)
        {

            return _lunchReservationDal.Get(p => p.Id == id);
        }

        public LunchReservation Update(LunchReservation foodReservation)
        {
            return _lunchReservationDal.Update(foodReservation);
        }
    }
}
