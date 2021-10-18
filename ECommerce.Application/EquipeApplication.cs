using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Application
{
    public class EquipeApplication : BaseApplication<Equipe>, IEquipeApplication
    {
        private readonly IEquipeService _service;
        public EquipeApplication(IEquipeService service) : base(service) => _service = service;
    }
}