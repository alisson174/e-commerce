using ECommerce.Domain.Models;
using System.Collections.Generic;

namespace ECommerce.Data.Repositories.Interfaces
{
    public interface IPedidoRepository : IBaseRepository<Pedido>
    {
        IList<Pedido> ListarPorDataCriacao(int quantidade);
        long Salvar(Pedido pedido);
    }
}