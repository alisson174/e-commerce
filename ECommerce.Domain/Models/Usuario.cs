using ECommerce.Domain.Interfaces;
using System;

namespace ECommerce.Domain.Models
{
    public class Usuario : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
    }
}