using ECommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Models
{
    public class Produto: IBaseEntity
    {
        #region Properties
        private string _nome;
        private decimal _valor;

        public long Id { get; set; }
        public string Nome { get => _nome; set => ValidarNome(value); }
        public string Descricao { get; set; }
        public decimal Valor { get => _valor; set => ValidarValor(value); }
        public DateTime DataCriacao { get; set; }
        #endregion

        #region Constructors
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
        #endregion

        #region Methods
        private void ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("O nome deve ser preenchido corretamente.");

            _nome = nome;
        }

        private void ValidarValor(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor do produto deve ser maior que zero.");

            _valor = valor;
        }
        #endregion
    }
}