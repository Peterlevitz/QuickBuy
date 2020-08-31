using QuickBuy.Dominio.entidades;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Dominio.contratos
{
    public class usuario
    {
        public int id { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }


        public ICollection<pedido> pedidos { get; set; }
    }
}
