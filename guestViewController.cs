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
   public class guestViewController : Controller
    {
        // GET: ReservationView
        public async Task<ActionResult> Index()
        {
            List<guestViewModel> users = new List<guestViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("guest"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<List<guestViewModel>>(apiResponse);
                }
            }
            return View(users);
        }
        public async Task<ActionResult> Create(guestViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                guestViewModel User = new guestViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("Reservation", userViewModel))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                       // User = JsonConvert.DeserializeObject<guestViewModel>(apiResponse);
                    }
                }



                return RedirectToAction("Index");
            }
            return View(userViewModel);

        }
        public async Task<ActionResult> Delete(int Id)
        {
            var service = new ServiceRepository();
            using (var response = service.DeleteResponse("guest/", Id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
            }
            return RedirectToAction("Index");
        }



    }
}


