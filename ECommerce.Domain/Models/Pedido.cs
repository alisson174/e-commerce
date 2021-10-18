using ECommerce.Domain.Interfaces;
using ECommerce.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Models
{
    public class Pedido : IBaseEntity
    {
        #region Properties
        private string _numero;

        public long Id { get; set; }
        public string Numero { get => _numero; set => ValidarNumero(value); }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public IList<PedidoProduto> PedidoProdutos { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
        public Endereco Endereco { get; set; }
        public long EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }
        #endregion

        #region Constructors
        public Pedido(string numero)
        {
            Numero = numero;
        }
        #endregion

        #region Methods
        private void ValidarNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                throw new Exception("O número do pedido deve ser informado");

            _numero = numero;
        }

        #endregion
    }
}