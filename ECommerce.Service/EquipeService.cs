using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Service
{
    public class EquipeService : BaseService<Equipe>, IEquipeService
    {
        private readonly IEquipeRepository _repository;
        public EquipeService(IEquipeRepository repository) : base(repository) => _repository = repository;
    }
}