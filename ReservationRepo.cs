using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi_HotelManagement.Models;

namespace WebApi_HotelManagement.Repository
{
    public class ReservationRepo : IReservation<Reservation>
    {
        ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 _context;

        public ReservationRepo(ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities1 context)
        {
            _context = context;
        }
        #region Get All Users
        public IEnumerable<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }
        #endregion

        #region GetByID
        public Reservation GetById(int Id)
        {
            return _context.Reservations.Find(Id);
        }
        #endregion
        #region Insert User
        public void Post(Reservation R)
        {
            _context.Reservations.Add(R);
            _context.SaveChanges();
        }
        #endregion
        #region To Delete
        public void Delete(int Id)
        {
            Reservation reservation = _context.Reservations.Find(Id);
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }
        #endregion

        #region To Update
        public void Put(int Id, Reservation R)
        {
            var reservation = new Reservation();
            reservation.Code = R.Code;
            reservation.NoofChildrens = R.NoofChildrens;
            reservation.NoofAdults = R.NoofAdults;
            reservation.Checkin = R.Checkin;
            reservation.Checkout = R.Checkout;
            reservation.NoofRooms = R.NoofRooms;
            reservation.Phno = R.Phno;
            _context.Entry(reservation).State = EntityState.Modified;
            _context.SaveChanges();
        }
        #endregion







    }
}

    

    
