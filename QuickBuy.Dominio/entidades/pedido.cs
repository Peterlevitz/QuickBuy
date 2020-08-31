using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.entidades
{
    public class pedido
    {
        public int Id { get; set; }

        public DateTime dataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime dataPrevisaoEntrega { get; set; }

        public string cep { get; set; }

        public string estado { get; set; }

        public string cidade { get; set; }

        public string enderecoCompleto { get; set; }

        public string numeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public formaPagamento FormaPagamento { get; set; }





    }
}
