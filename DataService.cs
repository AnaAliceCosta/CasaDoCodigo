using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using Newtonsoft;
using Newtonsoft.Json;
using CasaDoCodigo.Models;
using CasaDoCodigo.DAO;

namespace CasaDoCodigo
{

    public class DataService : IDataService
    {

        private readonly ApplicationContext contexto;
        private readonly IProdutoDao produtoDao;

        public DataService(ApplicationContext contexto,IProdutoDao produtoDao)
        {
            this.contexto = contexto;
            this.produtoDao = produtoDao;
        }
        public void InicializaDB()
        {
            contexto.Database.Migrate();
            List<Livro> livros = GetLivros();
            produtoDao.SavePrdutos(livros);

        }
        public List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            List<Livro> livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}

