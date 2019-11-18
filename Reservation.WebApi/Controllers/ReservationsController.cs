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
        private IBreakfastReservationService _breakfastReservationService;
        public ReservationsController(IBreakfastReservationService breakfastReservationService)
        {
            _breakfastReservationService = breakfastReservationService;
        }

        public List<BreakfastReservation> Get()
        {
            return _breakfastReservationService.GetAll();
          
        }
    }
}
