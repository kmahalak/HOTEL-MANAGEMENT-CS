using MVC_HotelManagement.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVC_HotelManagement.Models;


namespace MVC_HotelManagement.Controllers
{
    public class RegistrationViewController : Controller
    {
        // GET: RegistrationView
        public async Task<ActionResult> Index()
        {
            List<RegistrationViewModel> users = new List<RegistrationViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("Registration"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<List<RegistrationViewModel>>(apiResponse);
                }
            }
            return View(users);
        }
        public async Task<ActionResult> Create(RegistrationViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                RegistrationViewModel User = new RegistrationViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("Registration", userViewModel))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        User = JsonConvert.DeserializeObject<RegistrationViewModel>(apiResponse);
                    }
                }



                return RedirectToAction("Index");
            }
            return View(userViewModel);

        }
        public async Task<ActionResult> Delete(int Id)
        {
            var service = new ServiceRepository();
            using (var response = service.DeleteResponse("Registration/", Id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
            }
            return RedirectToAction("Index");
        }

    }
}