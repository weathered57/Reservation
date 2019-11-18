using AutoMapper;
using Reservation.Business.Abstract;
using Reservation.DataAccess.Abstract;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Concrete
{
    public class BreakfastReservationManager : IBreakfastReservationService
    {
        private IBreakfastReservationDal _breakfastReservationDal;
        private readonly IMapper _mapper;
        public BreakfastReservationManager(IBreakfastReservationDal foodReservationDal,IMapper mapper)
        {
            _breakfastReservationDal = foodReservationDal;
            _mapper = mapper;
        }
        public BreakfastReservation Add(BreakfastReservation foodReservation)
        {
            return _breakfastReservationDal.Add(foodReservation);
        }

        public List<BreakfastReservation> GetAll()
        {
            var breakfastReservations=_mapper.Map<List<BreakfastReservation>>(_breakfastReservationDal.GetList());
            return breakfastReservations;
        }

        public BreakfastReservation GetById(int id)
        {
           
            return _breakfastReservationDal.Get(p => p.Id == id);
        }

        public BreakfastReservation Update(BreakfastReservation foodReservation)
        {
            return _breakfastReservationDal.Update(foodReservation);
        }
    }
}
