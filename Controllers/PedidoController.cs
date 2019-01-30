using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaDoCodigo.Models;
using CasaDoCodigo.DAO;


namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoDAO produtoDao;
        private readonly IPedidoDAO pedidoDAO;

        public PedidoController(IProdutoDAO produtoDao,IPedidoDAO pedidoDAO)
        {
            this.produtoDao = produtoDao;
            this.pedidoDAO = pedidoDAO;
        }

        public IActionResult Carrossel()
        {  
            return View(produtoDao.GetProdutos());
        }
        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoDAO.AddItem(codigo);
            }
            Pedido pedido = pedidoDAO.GetPedido();
            return View(pedido.Itens);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }

    }
}
