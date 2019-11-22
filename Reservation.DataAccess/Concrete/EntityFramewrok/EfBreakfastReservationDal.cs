using Reservation.DataAccess.Abstract;
using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DataAccess.Concrete.EntityFramewrok
{
    public class EfBreakfastReservationDal : EfEntityRepositoryBase<ReservationContext, BreakfastReservation>, IBreakfastReservationDal
    {
        public List<BreakfastReservationDto> GetBreakfastReservaionDetailList()
        {
            using (ReservationContext context=new ReservationContext())
            {
                var result = (from br in context.BreakfastReservations
                              join b in context.Breakfasts
                              on br.ReservationDate equals b.Date
                              join s in context.Students
                              on br.StudentId equals s.Id
                              join Sln in context.Saloons
                             on br.SaloonId equals Sln.Id
                              select new BreakfastReservationDto
                              {
                                  Id=br.Id,
                                  ReservationDate=br.ReservationDate,
                                  SalonName=Sln.SaloonName,
                                  StudentName=s.Name,
                                  SchoolNo = s.SchoolNo,
                                  FirstMeal=b.First,
                                  SecondMeal = b.Second,
                                  ThirdMeal = b.Third,
                                  FourthMeal = b.Fourth,

                              }).ToList();

                return result;
            }
           

        }
    }
}
