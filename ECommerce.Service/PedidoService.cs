using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;
using System.Collections.Generic;

namespace ECommerce.Service
{
    public class PedidoService : BaseService<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _repository;
        public PedidoService(IPedidoRepository repository) : base(repository) => _repository = repository;

        public IList<Pedido> ListarPorDataCriacao(int quantidade) => _repository.ListarPorDataCriacao(quantidade);

        public long Salvar(Pedido pedido) => _repository.Salvar(pedido);
    }
}