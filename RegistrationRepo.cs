using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi_HotelManagement.Models;

namespace WebApi_HotelManagement.Repository
{
    public class RegistrationRepo : IRegistration<Registration>
    {
        ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 _context;

        public RegistrationRepo(ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 context)
        {
            _context = context;
        }
        #region Get All Users
        public IEnumerable<Registration> GetAll()
        {
            return _context.Registrations.ToList();
        }
        #endregion

        #region GetByID
        public Registration GetById(int Id)
        {
            return _context.Registrations.Find(Id);
        }
        #endregion
        #region Insert User
        public void Post(Registration R)
        {
            _context.Registrations.Add(R);
            _context.SaveChanges();
        }
        #endregion
        #region To Delete
        public void Delete(int Id)
        {
            Registration registration = _context.Registrations.Find(Id);
            _context.Registrations.Remove(registration);
            _context.SaveChanges();
        }
        #endregion

        #region To Update
        public void Put(int Id, Registration R)
        {
            var registration = new Registration();
            registration.FirstName = R.FirstName;
            registration.LastName = R.LastName;
            registration.Username = R.Username;
            registration.Role = R.Role;
            registration.Password = R.Password;
            registration.ConfirmPassword = R.ConfirmPassword;
            _context.Entry(registration).State = EntityState.Modified;
            _context.SaveChanges();
        }
        #endregion







    }
}

    
