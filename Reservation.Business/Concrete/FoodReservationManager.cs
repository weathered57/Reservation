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
    public class FoodReservationManager : IFoodReservationService
    {
        private IFoodReservationDal _foodReservationDal;

        public FoodReservationManager(IFoodReservationDal foodReservationDal)
        {
            _foodReservationDal = foodReservationDal;
        }
        public FoodReservation Add(FoodReservation foodReservation)
        {
            return _foodReservationDal.Add(foodReservation);
        }

        public List<FoodReservation> GetAll()
        {
            return _foodReservationDal.GetList();
        }

        public FoodReservation GetById(int id)
        {
           
            return _foodReservationDal.Get(p => p.Id == id);
        }

        public FoodReservation Update(FoodReservation foodReservation)
        {
            return _foodReservationDal.Update(foodReservation);
        }
    }
}
