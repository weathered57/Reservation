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

    [RoutePrefix("Api/LunchReservations")]
    public class LunchReservationsController : ApiController
    {
        private ILunchReservationService _lunchReservationService;
        public LunchReservationsController(ILunchReservationService lunchReservationService)
        {
            _lunchReservationService = lunchReservationService;
        }

        // GET: api/LunchReservations
        [Route("GetAll/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<LunchReservationDto> GetAll(int page = 1, int pageSize = 5)
        {
            try
            {
                var result = _lunchReservationService.GetLunchReservationDetailList().Skip((page - 1) * pageSize).Take(pageSize);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<LunchReservationDto> GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            try
            {
                var result = _lunchReservationService.GetLunchReservationDetailList().Where(x => x.ReservationDate > startDate && x.ReservationDate < endDate).Skip((page - 1) * pageSize).Take(pageSize);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // GET: api/LunchReservations/Get/5
        [Route("Get/{id}")]
        [HttpGet]
        public LunchReservation Get(int id)
        {
            try
            {
                var result = _lunchReservationService.GetById(id);
                return result;
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST: api/LunchReservations
        public void Post(LunchReservation lunchReservation)
        {          
            try
            {
                _lunchReservationService.Add(lunchReservation);
            }
            catch (Exception)
            {

                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}
