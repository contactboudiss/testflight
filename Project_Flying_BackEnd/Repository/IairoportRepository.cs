using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
   public  interface IairoportRepository<TEntity> 
    {

        TEntity get(int id);
        void  add(TEntity entity);
        void delete(int id);

        TEntity update(int id, TEntity entity);
    }
}
