using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Service
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository) : base(repository) => _repository = repository;
    }
}