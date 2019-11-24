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
                              on br.ReservationDate equals b.Date into df
                              from b1 in df.DefaultIfEmpty()
                              join s in context.Students
                            on br.StudentId equals s.Id into df1
                              from s1 in df1.DefaultIfEmpty()
                              join sln in context.Saloons  
                            on br.SaloonId equals sln.Id into df2
                      from sln1 in df2.DefaultIfEmpty()
                              select new LunchReservationDto
                              {
                                  Id = br.Id,
                                  ReservationDate = br.ReservationDate,
                                  SalonName = sln1.SaloonName,
                                  StudentName = s1.Name,
                                  SchoolNo = s1.SchoolNo,
                                  FirstMeal = b1.First,
                                  SecondMeal = b1.Second,
                                  ThirdMeal = b1.Third,
                                  FourthMeal = b1.Fourth,

                              }).ToList();

                return result;
            }


        }
    }
}
