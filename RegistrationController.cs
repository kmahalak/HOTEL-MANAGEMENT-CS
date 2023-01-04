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
    [RoutePrefix("api/Registration")]
    public class RegistrationController : ApiController
    {
        IRegistration<Registration> _data;
        public RegistrationController()
        {
            this._data = new RegistrationRepo(new ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1());
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Registration> GetAll()
        {
            var Registrations = _data.GetAll();
            return Registrations;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(Registration registration)
        {
            Registration registrationObj = null;
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                _data.Post(registration);
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
        public Registration GetbyId(int Id)
        {
            var registration = _data.GetById(Id);
            return registration;
        }

        [HttpPut]
        public IHttpActionResult Put(int Id, Registration registration)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Not a valid Details");
                _data.Put(Id, registration);
            }
            catch
            {
                throw;
            }
            return Ok("Updated Successfully");
        }


    }
}
