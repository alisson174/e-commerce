using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Service
{
    public class PedidoProdutoService : BaseService<PedidoProduto>, IPedidoProdutoService
    {
        private IPedidoProdutoRepository _repository;
        public PedidoProdutoService(IPedidoProdutoRepository repository) : base(repository) => _repository = repository;
    }
}