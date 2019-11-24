using AutoMapper;
using Reservation.Business.Abstract;
using Reservation.DataAccess.Abstract;
using Reservation.Entities.ComplexTypes;
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
        public BreakfastReservation Add(BreakfastReservation breakfastReservation)
        {
            return _breakfastReservationDal.Add(breakfastReservation);
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

        public BreakfastReservation Update(BreakfastReservation breakfastReservation)
        {
            return _breakfastReservationDal.Update(breakfastReservation);
        }
        public BreakfastReservation GetByDateWithStudent(DateTime date,int studentId)
        {
            return _breakfastReservationDal.Get(p => p.ReservationDate == date && p.StudentId == studentId);
        }
        public List<BreakfastReservationDto> GetBreakfastReservaionDetailList()
        {
            return _breakfastReservationDal.GetBreakfastReservaionDetailList();
        }

      
    }
}
    