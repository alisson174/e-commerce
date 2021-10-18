using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Application
{
    public class ProdutoApplication : BaseApplication<Produto>, IProdutoApplication
    {
        private readonly IProdutoService _service;
        public ProdutoApplication(IProdutoService service) : base(service) => _service = service;
    }
}