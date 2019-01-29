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

        public PedidoController(IProdutoDAO produtoDao)
        {
            this.produtoDao = produtoDao;
        }

        public IActionResult Carrossel()
        {  
            return View(produtoDao.GetProdutos());
        }
        public IActionResult Carrinho()
        {
            return View();
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
