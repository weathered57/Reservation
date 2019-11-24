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
    public class LunchReservationManager : ILunchReservationService
    {
        private ILunchReservationDal _lunchReservationDal;
        private readonly IMapper _mapper;

        public LunchReservationManager(ILunchReservationDal lunchReservationDal, IMapper mapper)
        {
            _lunchReservationDal = lunchReservationDal;
            _mapper = mapper;
        }
        public LunchReservation Add(LunchReservation foodReservation)
        {
            return _lunchReservationDal.Add(foodReservation);
        }

        public List<LunchReservation> GetAll()
        {
            var lunchReservations = _mapper.Map<List<LunchReservation>>(_lunchReservationDal.GetList());
            return lunchReservations;
        }

        public LunchReservation GetById(int id)
        {
            var lunchReservations = _mapper.Map<LunchReservation>(_lunchReservationDal.Get(p => p.Id == id));
            return lunchReservations;
        }
        public LunchReservation GetByDateWithStudent(DateTime date,int studentId)
        {
            return _lunchReservationDal.Get(p => p.ReservationDate == date && p.StudentId == studentId);
        }
        public LunchReservation Update(LunchReservation foodReservation)
        {
            return _lunchReservationDal.Update(foodReservation);
        }

        public List<LunchReservationDto> GetLunchReservationDetailList()
        {
            return _lunchReservationDal.GetLunchReservationDetailList();
        }
    }
}
