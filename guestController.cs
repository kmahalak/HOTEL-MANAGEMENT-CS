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
    [RoutePrefix("api/guest")]
    public class guestController : ApiController
    {
        
      
            Iguest<guest> _data;
            public guestController()
            {
                this._data = new guestRepo(new ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1());
            }
            [HttpGet]
            [Route("")]
            public IEnumerable<guest> GetAll()
            {
                var guests = _data.GetAll();
                return guests;
            }

            [HttpPost]
            [Route("")]
            public IHttpActionResult Post(guest guest)
            {
                guest guestObj = null;
                try
                {
                    if (!ModelState.IsValid)
                        return BadRequest("Invalid data.");
                    _data.Post(guest);
                }
                catch (Exception)
                {
                    throw;
                }
                return Ok("Saved Successfully");
            }
            [HttpDelete]
       
        public IHttpActionResult Delete(string Phno)
        {
            try
            {
                
                    return BadRequest("not valid");
                _data.Delete(Phno);

            }
            catch
            {

                throw;
            }
            return Ok("Deleted successfully");
        }


        [HttpPut]
            public IHttpActionResult Put(string Phno, guest guest)
            {
                try
                {
                    if (!ModelState.IsValid)
                        return BadRequest("Not a valid Details");
                    _data.Put(Phno, guest);
                }
                catch
                {
                    throw;
                }
                return Ok("Updated Successfully");
            }


        }
    }



