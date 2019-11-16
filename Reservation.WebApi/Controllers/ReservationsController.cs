using Reservation.Business.Abstract;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Reservation.WebApi.Controllers
{
    public class ReservationsController : ApiController
    {
        private IFoodReservationService _foodReservationService;
        public ReservationsController(IFoodReservationService foodReservationService)
        {
            _foodReservationService = foodReservationService;
        }

        public List<FoodReservation> Get()
        {
            return _foodReservationService.GetAll().Select(f=> new FoodReservation
            {
                Id=f.Id,
                IsBreakfast= f.IsBreakfast,
                IsDinner = f.IsDinner,
                IsLunch = f.IsLunch,
                SaloonId = f.SaloonId,
                StudentId = f.StudentId,
                CreatedReservation=f.CreatedReservation
            }).ToList();
        }
    }
}
