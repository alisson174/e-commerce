using ECommerce.Domain.Models;
using System.Collections.Generic;

namespace ECommerce.Service.Interfaces
{
    public interface IPedidoService : IBaseService<Pedido>
    {
        IList<Pedido> ListarPorDataCriacao(int quantidade);
        long Salvar(Pedido pedido);
    }
}