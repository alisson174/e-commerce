using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Service
{
    public class UsuarioService: BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository) : base(repository) => _repository = repository;

        public Usuario EncontrarPorLoginSenha(LoginDto dto) => _repository.EncontrarPorLoginSenha(dto);
    }
}