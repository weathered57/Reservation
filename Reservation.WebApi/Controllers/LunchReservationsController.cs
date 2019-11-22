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
   
            return _lunchReservationService.GetLunchReservationDetailList().Skip((page - 1) * pageSize).Take(pageSize);

        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<LunchReservationDto> GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            return _lunchReservationService.GetLunchReservationDetailList().Where(x => x.ReservationDate > startDate && x.ReservationDate < endDate).Skip((page - 1) * pageSize).Take(pageSize);
        }

        // GET: api/LunchReservations/Get/5
        [Route("Get")]
        [HttpGet]
        public LunchReservation Get(int id)
        {
            return _lunchReservationService.GetById(id);
        }

        // POST: api/LunchReservations
        public void Post(LunchReservation lunchReservation)
        {
            _lunchReservationService.Add(lunchReservation);
        }
    }
}
