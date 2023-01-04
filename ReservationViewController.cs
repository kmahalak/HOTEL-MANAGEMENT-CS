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
    public class ReservationViewController : Controller
    {
        // GET: ReservationView
        public async Task<ActionResult> Index()
        {
            List<ReservationViewModel> users = new List<ReservationViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("Reservation"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<List<ReservationViewModel>>(apiResponse);
                }
            }
            return View(users);
        }
        public async Task<ActionResult> Create(ReservationViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                ReservationViewModel User = new ReservationViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("Reservation", userViewModel))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        User = JsonConvert.DeserializeObject<ReservationViewModel>(apiResponse);
                    }
                }



                return RedirectToAction("Index");
            }
            return View(userViewModel);

        }
        public async Task<ActionResult> Delete(int Id)
        {
            var service = new ServiceRepository();
            using (var response = service.DeleteResponse("Reservation/", Id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
            }
            return RedirectToAction("Index");
        }



    }
}
        
    
