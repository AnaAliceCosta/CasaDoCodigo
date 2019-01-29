using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{

    public class Pedido : BaseModel
    {
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        [Required]
        public int CadastroId { get; set; }
        public virtual Cadastro Cadastro { get; private set; }
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }


    }
}
