using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Application.Interfaces
{
    public interface IUsuarioApplication: IBaseApplication<Usuario>
    {
        Usuario Login(LoginDto dto);
    }
}