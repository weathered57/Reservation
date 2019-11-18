using AutoMapper;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Mapping.AutoMapper.Profiles
{
   public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<BreakfastReservation, BreakfastReservation>();
        }
    }
}
