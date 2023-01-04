using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using WebApi_HotelManagement.Models;

namespace WebApi_HotelManagement.Repository
{
    public class guestRepo : Iguest<guest>
    {
       
            ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 _context;

            public guestRepo(ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 context)
            {
                _context = context;
            }
            #region Get All Users
            public IEnumerable<guest> GetAll()
            {
                return _context.guests.ToList();
            }

        #endregion
        #region GetByPhno
            public guest GetById(string Phno)
            {
                return _context.guests.Find(Phno);
            }
            #endregion
            #region Insert User
            public void Post(guest R)
            {
                _context.guests.Add(R);
                _context.SaveChanges();
            }
            #endregion
            #region To Delete
            public void Delete(string Phno)
            {
                guest guest = _context.guests.Find(Phno);
                _context.guests.Remove(guest);
                _context.SaveChanges();
            }
            #endregion

            #region To Update
            public void Put(string Phno, guest R)
            {
                var guest = new guest();
                guest.GuestName = R.GuestName;
                guest.Address = R.Address;
                guest.Phno = R.Phno;
                guest.Gender= R.Gender;
               
                _context.Entry(guest).State = EntityState.Modified;
                _context.SaveChanges();
            }

        public guest GetByPhno(string Phno)
        {
            throw new NotImplementedException();
        }


        #endregion







    }
    }


