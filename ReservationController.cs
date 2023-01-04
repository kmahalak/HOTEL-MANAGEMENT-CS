using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_HotelManagement.Models;
using WebApi_HotelManagement.Repository;

namespace WebApi_HotelManagement.Controllers
{
    [RoutePrefix("api/Reservation")]
    public class ReservationController : ApiController
    {
        IReservation<Reservation> _data;
        public ReservationController()
        {
            this._data = new ReservationRepo(new ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1());
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Reservation> GetAll()
        {
            var Reservations = _data.GetAll();
            return Reservations;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(Reservation reservation)
        {
            Reservation reservationObj = null;
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                _data.Post(reservation);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok("Saved Successfully");
        }
        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            try
            {
                if (Id <= 0)
                    return BadRequest("not valid");
                _data.Delete(Id);

            }
            catch
            {

                throw;
            }
            return Ok("Deleted successfully");
        }

        [HttpGet]
        [Route("")]
        public Reservation GetbyId(int Id)
        {
            var reservation = _data.GetById(Id);
            return reservation;
        }

        [HttpPut]
        public IHttpActionResult Put(int Id, Reservation reservation)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Not a valid Details");
                _data.Put(Id, reservation);
            }
            catch
            {
                throw;
            }
            return Ok("Updated Successfully");
        }


    }
}

    

