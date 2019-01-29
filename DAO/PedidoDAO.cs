using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{
    public interface IPedidoDAO
    {
        
    }
    public class PedidoDAO :BaseDAO<Pedido> ,IPedidoDAO
    {
        
        public PedidoDAO(ApplicationContext context): base(context)
        {
        }
        
        

    }

}
