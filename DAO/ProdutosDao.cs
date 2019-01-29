using System.Collections.Generic;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{

    public class ProdutoDao :IProdutoDao
    {
        private  readonly ApplicationContext contexto;

        public ProdutoDao(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void SavePrdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {


                contexto.Set<Produto>().Add(new Produto(livro.Nome, livro.Codigo, livro.Preco));
            }
            contexto.SaveChanges();
        }

    }

}
