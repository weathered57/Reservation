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
        public HttpResponseMessage GetAll(int page = 1, int pageSize = 5)
        {
            try
            {
                var result = _dinnerReservationService.GetDinnerReservationDetailList().Skip((page - 1) * pageSize).Take(pageSize);
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
                var result= _dinnerReservationService.GetDinnerReservationDetailList().Where(x => x.ReservationDate >= startDate && x.ReservationDate <= endDate).Skip((page - 1) * pageSize).Take(pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        // GET: api/DinnerReservations/Get/5
        [Route("Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var result= _dinnerReservationService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        // POST: api/DinnerReservations
        public HttpResponseMessage Post(DinnerReservation dinnerReservation)
        {      
            try
            {
                var dateWithStudentResult = _dinnerReservationService.GetByDateWithStudent(dinnerReservation.ReservationDate, dinnerReservation.StudentId);
                if (dateWithStudentResult != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Kullanıcıya ait Aynı tarihli Rezervasyon bulunuyor.");
                }
                var result= _dinnerReservationService.Add(dinnerReservation);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }
    }
}
