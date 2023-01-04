using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApi_HotelManagement.Models;
using WebApi_HotelManagement.Repository;

namespace WebApi_HotelManagement.Repository
{
    public class LoginRepo : ILogin
    {
        ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 _LoginEntities = null;
        public Registration VerifyLogin(string Username, string Password)
        {
            Registration user = null;
            try
            {
                var checkValidUser = _LoginEntities.Registrations.Where(m => m.Username == Username && m.Password == Password).FirstOrDefault();
                if (checkValidUser != null)
                {
                    user = checkValidUser;
                }

                else
                {
                    user = null;
                }
            }
            catch (Exception ex)
            {
            }
            return user;
        }

        public LoginRepo(ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 loginentities)
        {
            this._LoginEntities = loginentities;
        }

    }
}
