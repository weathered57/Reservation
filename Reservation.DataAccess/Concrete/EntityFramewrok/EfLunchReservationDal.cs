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
    public class EfLunchReservationDal : EfEntityRepositoryBase<ReservationContext, LunchReservation>, ILunchReservationDal
    {
        public List<LunchReservationDto> GetLunchReservationDetailList()
        {
            using (ReservationContext context = new ReservationContext())
            {
                var result = (from br in context.LunchReservations
                              join b in context.Lunchs
                              on br.ReservationDate equals b.Date
                              join S in context.Students
                            on br.StudentId equals S.Id
                              join Sln in context.Saloons
                            on br.SaloonId equals Sln.Id
                              select new LunchReservationDto
                              {
                                  Id = br.Id,
                                  ReservationDate = br.ReservationDate,
                                  SalonName = Sln.SaloonName,
                                  StudentName = S.Name,
                                  SchoolNo = S.SchoolNo,
                                  FirstMeal = b.First,
                                  SecondMeal = b.Second,
                                  ThirdMeal = b.Third,
                                  FourthMeal = b.Fourth,

                              }).ToList();

                return result;
            }


        }
    }
}
