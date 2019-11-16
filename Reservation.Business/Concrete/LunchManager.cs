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
    public class LunchManager : ILunchService
    {
        private ILunchDal _lunchDal;
        public LunchManager(ILunchDal lunchDal)
        {
            _lunchDal = lunchDal;
        }
        public Lunch Add(Lunch lunch)
        {
            return _lunchDal.Add(lunch);
        }

        public List<Lunch> GetAll()
        {
            return _lunchDal.GetList();
        }

        public Lunch GetByDate(DateTime date)
        {
            return _lunchDal.Get(x=>x.Date==date);
        }

        public Lunch Update(Lunch lunch)
        {
            return _lunchDal.Update(lunch);
        }
    }
}
