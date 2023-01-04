using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_HotelManagement.Repository
{
    internal interface IReservation<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Post(TEntity Reservation);
        void Put(int id, TEntity R);
        void Delete(int id);
    }
}
