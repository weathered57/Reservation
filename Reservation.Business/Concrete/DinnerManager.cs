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
    public class DinnerManager : IDinnerService
    {
        private IDinnerDal _dinnerReservationDal;

        public DinnerManager(IDinnerDal dinnerReservationDal)
        {
            _dinnerReservationDal = dinnerReservationDal;
        }
        public Dinner Add(Dinner dinner)
        {
            return _dinnerReservationDal.Add(dinner);
        }

        public List<Dinner> GetAll()
        {
            return _dinnerReservationDal.GetList();
        }

        public Dinner GetByDate(DateTime date)
        {
            return _dinnerReservationDal.Get(d=>d.Date==date);
        }

        public Dinner Update(Dinner dinner)
        {
            return _dinnerReservationDal.Update(dinner);
        }
    }
}
