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
    public class BreakfastManager : IBreakfastService
    {
        private IBreakfastDal _breakfastReservationDal;

        public BreakfastManager(IBreakfastDal breakfastReservationDal)
        {
            _breakfastReservationDal = breakfastReservationDal;
        }
        public Breakfast Add(Breakfast breakfast)
        {
            return _breakfastReservationDal.Add(breakfast);
        }

        public List<Breakfast> GetAll()
        {
            return _breakfastReservationDal.GetList();
        }

        public Breakfast GetByDate(DateTime date)
        {

            return _breakfastReservationDal.Get(p => p.Date == date);
        }

        public Breakfast Update(Breakfast breakfast)
        {
            return _breakfastReservationDal.Update(breakfast);
        }
    }
}
