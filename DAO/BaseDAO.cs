using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{

    public class BaseDAO<T> where T:BaseModel
    {
        protected  readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;
        public BaseDAO(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();

        }

        
        

    }

}
