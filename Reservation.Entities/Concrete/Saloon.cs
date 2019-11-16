using Reservation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.Concrete
{
    public class Saloon : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string SaloonName { get; set; }
    }
}
