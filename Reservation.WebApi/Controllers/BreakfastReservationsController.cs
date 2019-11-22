using Reservation.Business.Abstract;
using Reservation.Entities.ComplexTypes;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Reservation.WebApi.Controllers
{
    [RoutePrefix("Api/BreakfastReservations")]
    public class BreakfastReservationsController : ApiController
    {
        private IBreakfastReservationService _breakfastReservationService;
        public BreakfastReservationsController(IBreakfastReservationService breakfastReservationService)
        {
            _breakfastReservationService = breakfastReservationService;
        }
        [Route("GetAll/{page?}/{pageSize?}")]
        [HttpGet]
        // GET: api/BreakfastReservations
        public IEnumerable<BreakfastReservationDto> GetAll(int page=1,int pageSize=5)
        {
            return _breakfastReservationService.GetBreakfastReservaionDetailList().Skip((page-1) * pageSize).Take(pageSize);
        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<BreakfastReservationDto> GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            return _breakfastReservationService.GetBreakfastReservaionDetailList().Where(x => x.ReservationDate > startDate && x.ReservationDate < endDate).Skip((page - 1) * pageSize).Take(pageSize);
        }

        // GET: api/BreakfastReservations/Get/5
        [Route("Get")]
        [HttpGet]
        public BreakfastReservation Get(int id)
        {
            return _breakfastReservationService.GetById(id);
        }

        // POST: api/BreakfastReservations
        public void Post(BreakfastReservation breakfastReservation)
        {
             _breakfastReservationService.Add(breakfastReservation);
        }

      
    }
}
