using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.entidades
{
    public class produto
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string desc { get; set; }

        public decimal preco { get; set; }
    }
}
