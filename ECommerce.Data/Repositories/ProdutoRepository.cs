using ECommerce.Data.Context;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DbContextOptions<DataContext> _options;
        public ProdutoRepository(DbContextOptions<DataContext> options) : base(options) => _options = options;
    }
}