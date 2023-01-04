using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_HotelManagement.Repository
{
  
        internal interface Iguest<TEntity>
        {
            IEnumerable<TEntity> GetAll();
            TEntity GetByPhno(string Phno);
            void Post(TEntity guest);
            void Put(string Phno, TEntity R);
            void Delete(string Phno);
        }
    }

