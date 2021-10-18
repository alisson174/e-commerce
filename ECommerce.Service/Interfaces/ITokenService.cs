using ECommerce.Domain.Models;

namespace ECommerce.Service.Interfaces
{
    public interface ITokenService
    {
        string GerarToken(Usuario usuario);
    }
}
