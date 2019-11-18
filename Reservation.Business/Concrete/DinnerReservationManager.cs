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
    public class DinnerReservationManager : IDinnerReservationService
    {
        private IDinnerReservationDal _dinnerReservationDal;

        public DinnerReservationManager(IDinnerReservationDal dinnerReservationDal)
        {
            _dinnerReservationDal = dinnerReservationDal;
        }
        public DinnerReservation Add(DinnerReservation dinnerReservation)
        {
           return _dinnerReservationDal.Add(dinnerReservation);
        }

        public List<DinnerReservation> GetAll()
        {
            return _dinnerReservationDal.GetList();
        }

        public DinnerReservation GetById(int id)
        {
            return _dinnerReservationDal.Get(d=>d.Id == id);
        }

        public DinnerReservation Update(DinnerReservation dinnerReservation)
        {
            return _dinnerReservationDal.Update(dinnerReservation);
        }
    }
}
