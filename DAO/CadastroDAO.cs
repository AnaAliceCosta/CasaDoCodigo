using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;



namespace CasaDoCodigo.DAO
{
    public interface ICadastroDAO
    { }

    public class CadastroDAO : BaseDAO<Cadastro>, ICadastroDAO
    {

        public CadastroDAO(ApplicationContext context) : base(context)
        {

        }


    }

}
