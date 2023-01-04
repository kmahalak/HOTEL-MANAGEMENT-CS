using MVC_HotelManagement.Models;
using MVC_HotelManagement.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC_HotelManagement.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Register(RegistrationViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                RegistrationViewModel User = new RegistrationViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("Registration", userViewModel))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        //User = JsonConvert.DeserializeObject<RegistrationViewModel>(apiResponse);
                    }
                }



                return RedirectToAction("LoginUser","Login");
            }
            return View(userViewModel);

        }
    }
}