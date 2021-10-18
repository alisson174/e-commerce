using ECommerce.Domain.Interfaces;
using System;

namespace ECommerce.Domain.Models
{
    public class PedidoProduto : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public long PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public long? ProdutoId { get; set; }
    }
}