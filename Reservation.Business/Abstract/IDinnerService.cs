using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface IDinnerService
    {
        List<Dinner> GetAll();
        Dinner GetByDate(DateTime date);
        Dinner Add(Dinner dinner);
        Dinner Update(Dinner dinner);
    }
}
