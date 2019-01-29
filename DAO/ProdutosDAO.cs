using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{

    public class ProdutoDAO :BaseDAO<Produto>, IProdutoDAO
    {
        
        public ProdutoDAO(ApplicationContext context): base(context)
        {
        }
        public IList<Produto> GetProdutos()
        {
            return contexto.Set<Produto>().ToList();
        }

        public void SavePrdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                
                if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())

                dbSet.Add(new Produto(livro.Nome, livro.Codigo, livro.Preco));
            }
            contexto.SaveChanges();
        }
        
        

    }

}
