using Reservation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.Concrete
{
    public class BreakfastReservation : IEntity
    {
      
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int StudentId { get; set; }
        public int SaloonId { get; set; }
        public DateTime CreatedReservation { get; set; }

    }
}
