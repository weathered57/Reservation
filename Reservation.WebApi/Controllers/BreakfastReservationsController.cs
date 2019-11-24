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
        public HttpResponseMessage GetAll(int page=1,int pageSize=20)
        {
            try
            {
                var result= _breakfastReservationService.GetBreakfastReservaionDetailList().Skip((page - 1) * pageSize).Take(pageSize);
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
                var result= _breakfastReservationService.GetBreakfastReservaionDetailList().Where(x => x.ReservationDate >= startDate && x.ReservationDate <= endDate).Skip((page - 1) * pageSize).Take(pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                 return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }            
        }

        // GET: api/BreakfastReservations/Get/5
        [Route("Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var result = _breakfastReservationService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

        // POST: api/BreakfastReservations
        public HttpResponseMessage Post(BreakfastReservation breakfastReservation)
        {   
            try
            {
                var dateWithStudentResult = _breakfastReservationService.GetByDateWithStudent(breakfastReservation.ReservationDate,breakfastReservation.StudentId);
                if(dateWithStudentResult != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Kullanıcıya ait Aynı tarihli Rezervasyon bulunuyor.");
                }
                var result= _breakfastReservationService.Add(breakfastReservation);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Hata Oluştu");
            }
        }

      
    }
}
