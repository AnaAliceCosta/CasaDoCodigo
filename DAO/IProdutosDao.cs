using System.Collections.Generic;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{

    public interface IProdutoDAO
    {
        void SavePrdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }

}
