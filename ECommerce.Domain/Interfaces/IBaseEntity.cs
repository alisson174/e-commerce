using System;

namespace ECommerce.Domain.Interfaces
{
    public interface IBaseEntity
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}