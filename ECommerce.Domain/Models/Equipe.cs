using ECommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Models
{
    public class Equipe : IBaseEntity
    {
        #region Properties
        private string _nome;

        public long Id { get; set; }
        public string Nome { get => _nome; set => ValidarNome(value); }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public string PlacaVeiculo { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        #endregion

        #region Constructors
        public Equipe(string nome, string placaVeiculo)
        {
            Nome = nome;
        }
        #endregion

        #region Methods
        private void ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("O nome deve ser preenchido corretamente.");

            _nome = nome;
        }
        #endregion
    }
}