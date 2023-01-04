using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using WebApi_HotelManagement.Models;
using WebApi_HotelManagement.Repository;

namespace WebApi_HotelManagement.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        private ILogin _account;
        public LoginController()
        {
            this._account = new LoginRepo(new ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1());
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult VerifyLogin(Login objlogin)
        {
            Registration user = null;
            try
            {
                user = _account.VerifyLogin(objlogin.Username, objlogin.Password);

                if (user != null)
                {

                    return Ok(user);

                }

            }
            catch (Exception ex)
            {
                throw;

            }


            return NotFound();

        }
    }
}
