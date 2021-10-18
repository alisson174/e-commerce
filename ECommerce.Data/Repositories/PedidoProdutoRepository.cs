using ECommerce.Data.Context;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Repositories
{
    public class PedidoProdutoRepository : BaseRepository<PedidoProduto>, IPedidoProdutoRepository
    {
        private DbContextOptions<DataContext> _options;
        public PedidoProdutoRepository(DbContextOptions<DataContext> options) : base(options) => _options = options;
    }
}