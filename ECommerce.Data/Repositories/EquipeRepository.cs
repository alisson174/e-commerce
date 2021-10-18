using ECommerce.Data.Context;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Repositories
{
    public class EquipeRepository : BaseRepository<Equipe>, IEquipeRepository
    {
        private readonly DbContextOptions<DataContext> _options;
        public EquipeRepository(DbContextOptions<DataContext> options) : base(options) => _options = options;
    }
}