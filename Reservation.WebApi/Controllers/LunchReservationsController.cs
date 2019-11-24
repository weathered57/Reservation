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
        public HttpResponseMessage GetAll(int page = 1, int pageSize = 5)
        {
            try
            {
                var result = _lunchReservationService.GetLunchReservationDetailList().Skip((page - 1) * pageSize).Take(pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        [Route("GetByDate/{startDate}/{endDate}/{page?}/{pageSize?}")]
        [HttpGet]
        public HttpResponseMessage GetByDate(DateTime startDate, DateTime endDate, int page = 1, int pageSize = 5)
        {
            try
            {
                var result = _lunchReservationService.GetLunchReservationDetailList().Where(x => x.ReservationDate >= startDate && x.ReservationDate <= endDate).Skip((page - 1) * pageSize).Take(pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        // GET: api/LunchReservations/Get/5
        [Route("Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var result = _lunchReservationService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        // POST: api/LunchReservations
        public HttpResponseMessage Post(LunchReservation lunchReservation)
        {
            try
            {
                var dateWithStudentResult = _lunchReservationService.GetByDateWithStudent(lunchReservation.ReservationDate, lunchReservation.StudentId);
                if (dateWithStudentResult != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Kullanıcıya ait Aynı tarihli Rezervasyon bulunuyor.");
                }
                var result = _lunchReservationService.Add(lunchReservation);
                return Request.CreateResponse(HttpStatusCode.Created, result);
            }
            catch (Exception)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Eklenemedi");
            }
        }
    }
}
