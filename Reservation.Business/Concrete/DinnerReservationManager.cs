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
    public class DinnerReservationManager : IDinnerReservationService
    {
        private IDinnerReservationDal _dinnerReservationDal;
        private readonly IMapper _mapper;

        public DinnerReservationManager(IDinnerReservationDal dinnerReservationDal, IMapper mapper)
        {
            _dinnerReservationDal = dinnerReservationDal;
            _mapper = mapper;
        }
        public DinnerReservation Add(DinnerReservation dinnerReservation)
        {
            return _dinnerReservationDal.Add(dinnerReservation);
        }

        public List<DinnerReservation> GetAll()
        {
            var dinnerReservations = _mapper.Map<List<DinnerReservation>>(_dinnerReservationDal.GetList());
            return dinnerReservations;
        }

        public DinnerReservation GetById(int id)
        {
            var dinnerReservation = _mapper.Map<DinnerReservation>(_dinnerReservationDal.Get(d => d.Id == id));
            return dinnerReservation;
        }
        public DinnerReservation GetByDateWithStudent(DateTime date,int studentId)
        {
            return _dinnerReservationDal.Get(p => p.ReservationDate == date && p.StudentId == studentId);

        }
        public DinnerReservation Update(DinnerReservation dinnerReservation)
        {
            return _dinnerReservationDal.Update(dinnerReservation);
        }

        public List<DinnerReservationDto> GetDinnerReservationDetailList()
        {
            return _dinnerReservationDal.GetDinnerReservationDetailList();
        }
    }
}
