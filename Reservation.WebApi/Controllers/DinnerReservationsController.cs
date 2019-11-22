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
    [RoutePrefix("Api/DinnerReservations")]
    public class DinnerReservationsController : ApiController
    {
        private IDinnerReservationService _dinnerReservationService;
        public DinnerReservationsController(IDinnerReservationService dinnerReservationService)
        {
            _dinnerReservationService = dinnerReservationService;
        }

        // GET: api/DinnerReservations
        [Route("GetAll/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<DinnerReservationDto> GetAll(int page = 1, int pageSize = 5)
        {
            return _dinnerReservationService.GetDinnerReservationDetailList().Skip((page - 1) * pageSize).Take(pageSize);
        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public IEnumerable<DinnerReservationDto> GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            return _dinnerReservationService.GetDinnerReservationDetailList().Where(x => x.ReservationDate > startDate && x.ReservationDate < endDate).Skip((page - 1) * pageSize).Take(pageSize);
        }

        // GET: api/DinnerReservations/Get/5
        [Route("Get")]
        [HttpGet]
        public DinnerReservation Get(int id)
        {
            return _dinnerReservationService.GetById(id);
        }

        // POST: api/DinnerReservations
        public void Post(DinnerReservation dinnerReservation)
        {
            _dinnerReservationService.Add(dinnerReservation);
        }
    }
}
