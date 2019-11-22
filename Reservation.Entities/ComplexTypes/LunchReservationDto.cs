using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.ComplexTypes
{
    public class LunchReservationDto
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string StudentName { get; set; }
        public int SchoolNo { get; set; }
        public string SalonName { get; set; }
        public string FirstMeal { get; set; }
        public string SecondMeal { get; set; }
        public string ThirdMeal { get; set; }
        public string FourthMeal { get; set; }
    }
}
