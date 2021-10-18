using ECommerce.Domain.Models;
using System.Collections.Generic;

namespace ECommerce.Application.Interfaces
{
    public interface IPedidoApplication : IBaseApplication<Pedido>
    {
        IList<Pedido> ListarPorDataCriacao(int quantidade);
    }
}