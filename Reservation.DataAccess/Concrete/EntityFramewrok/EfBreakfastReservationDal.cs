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
                              on br.ReservationDate equals b.Date into df
                              from br1 in df.DefaultIfEmpty()
                              join s in context.Students.DefaultIfEmpty()
                              on br.StudentId equals s.Id into df1
                              from s1 in df1.DefaultIfEmpty()
                              join sln in context.Saloons.DefaultIfEmpty()
                             on br.SaloonId equals sln.Id into df2
                              from sln1 in df2.DefaultIfEmpty()
                              select new BreakfastReservationDto
                              {
                                  Id=br.Id,
                                  ReservationDate=br.ReservationDate,
                                  SalonName= sln1.SaloonName,
                                  StudentName=s1.Name,
                                  SchoolNo = s1.SchoolNo,
                                  FirstMeal= br1.First,
                                  SecondMeal = br1.Second,
                                  ThirdMeal = br1.Third,
                                  FourthMeal = br1.Fourth,

                              }).ToList();

                return result;
            }
           

        }
    }
}
