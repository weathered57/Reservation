using Reservation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.Concrete
{
    public class Saloon : IEntity
    {
        public int Id { get; set; }
        public string SaloonName { get; set; }
    }
}
