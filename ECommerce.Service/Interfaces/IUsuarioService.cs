using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Service.Interfaces
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Usuario EncontrarPorLoginSenha(LoginDto dto);
    }
}