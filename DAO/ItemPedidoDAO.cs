using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{
    public interface IItemPedidoDAO
    {

    }
    public class ItemPedidoDAO : BaseDAO<ItemPedido>, IItemPedidoDAO
    {

        public ItemPedidoDAO(ApplicationContext context) : base(context)
        {
        }



    }

}
