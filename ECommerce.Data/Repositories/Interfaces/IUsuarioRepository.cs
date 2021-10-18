using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario EncontrarPorLoginSenha(LoginDto dto);
    }
}