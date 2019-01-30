using System;
using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{
    public interface IPedidoDAO
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
    public class PedidoDAO :BaseDAO<Pedido> ,IPedidoDAO
    {
        private readonly IHttpContextAccessor contextAccessor;
        public PedidoDAO(ApplicationContext context,IHttpContextAccessor contextAccessor): base(context)
        {
            this.contextAccessor = contextAccessor;
        }
        private int? GetPedidoId()
        {
             return contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }
        private void SetPedidoId(int pedidoId)
        {
            contextAccessor.HttpContext.Session.SetInt32("pedidoId",pedidoId);
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet
                    .Include(p => p.Itens)
                        .ThenInclude(i => i.Produto)
                    .Where(p => p.Id == pedidoId)
                    .SingleOrDefault();
            if(pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }
            return pedido;
        }

        public void AddItem(string codigo)
        {
            var produto = contexto.Set<Produto>()
                            .Where(p => p.Codigo == codigo)
                            .SingleOrDefault();
            if (produto == null)
            {
                throw new  ArgumentException("Produto não encontrado");
            }
            var pedido = GetPedido();
            var itemPedido = contexto.Set<ItemPedido>()
                                .Where(i => i.Produto.Id == pedido.Id)
                                .SingleOrDefault();
            if(itemPedido == null)
            {
                itemPedido = new ItemPedido(pedido,produto,1,produto.Preco);
                contexto.Set<ItemPedido>().Add(itemPedido);
                contexto.SaveChanges();
            }
                
        }
    }

}
