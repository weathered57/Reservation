using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface ISaloonService
    {
        List<Saloon> GetAll();
        Saloon GetById(int id);
        Saloon Add(Saloon saloon);
        Saloon Update(Saloon saloon);
    }
}
