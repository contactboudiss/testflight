using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Service
{
    public interface IuserService<TEntity>
    {

        TEntity get(int id);
    }
}
