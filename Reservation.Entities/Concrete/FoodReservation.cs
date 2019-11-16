using Reservation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.Concrete
{
    public class FoodReservation : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SaloonId { get; set; }
        public bool IsBreakfast { get; set; }
        public bool IsLunch { get; set; }
        public bool IsDinner { get; set; }
        public DateTime CreatedReservation { get; set; }

    }
}
