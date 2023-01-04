using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_HotelManagement.Models;

namespace WebApi_HotelManagement.Repository
{
    public interface IRegistration<TEntity>
    {
        
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Post(TEntity Registration);
        void Put(int id, TEntity R);
        void Delete(int id);

    }
}

