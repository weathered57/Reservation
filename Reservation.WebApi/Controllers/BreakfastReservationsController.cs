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
            try
            {
                var result= _breakfastReservationService.GetBreakfastReservaionDetailList().Skip((page - 1) * pageSize).Take(pageSize);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<BreakfastReservationDto> GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            try
            {
                var result= _breakfastReservationService.GetBreakfastReservaionDetailList().Where(x => x.ReservationDate > startDate && x.ReservationDate < endDate).Skip((page - 1) * pageSize).Take(pageSize);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }            
        }

        // GET: api/BreakfastReservations/Get/5
        [Route("Get/{id}")]
        [HttpGet]
        public BreakfastReservation Get(int id)
        {
            try
            {
                var result = _breakfastReservationService.GetById(id);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST: api/BreakfastReservations
        public void Post(BreakfastReservation breakfastReservation)
        {   
            try
            {
                _breakfastReservationService.Add(breakfastReservation);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

      
    }
}
