using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
   public interface IuserRepository<TEntity>
    {
        TEntity get(int id);

    }
}
