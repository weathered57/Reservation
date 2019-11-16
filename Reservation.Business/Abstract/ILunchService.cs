using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
   public interface ILunchService
    {
        List<Lunch> GetAll();
        Lunch GetByDate(DateTime date);
        Lunch Add(Lunch lunch);
        Lunch Update(Lunch lunch);
    }
}
