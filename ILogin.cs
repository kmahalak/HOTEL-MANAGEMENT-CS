using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_HotelManagement.Models;

namespace WebApi_HotelManagement.Repository
{
    internal interface ILogin
    {
        Registration VerifyLogin(string userName, string password);
    }
}
