using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface IBreakfastService 
    {
        List<Breakfast> GetAll();
        Breakfast GetByDate(DateTime date);
        Breakfast Add(Breakfast breakfast);
        Breakfast Update(Breakfast breakfast);
    }
}
