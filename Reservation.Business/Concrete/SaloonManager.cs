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
    public class SaloonManager : ISaloonService
    {
        private ISaloonDal _saloonDal;

        public SaloonManager(ISaloonDal saloonDal)
        {
            _saloonDal = saloonDal;
        }
        public Saloon Add(Saloon saloon)
        {
            return _saloonDal.Add(saloon);
        }

        public List<Saloon> GetAll()
        {
            return _saloonDal.GetList();
        }

        public Saloon GetById(int id)
        {
            return _saloonDal.Get(x=>x.Id == id);
        }

        public Saloon Update(Saloon saloon)
        {
            return _saloonDal.Update(saloon);
        }
    }
}
