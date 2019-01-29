using System.Collections.Generic;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{

    public interface IProdutoDao
    {
        void SavePrdutos(List<Livro> livros);
    }

}
