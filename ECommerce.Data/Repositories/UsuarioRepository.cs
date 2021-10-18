using ECommerce.Data.Context;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerce.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly DbContextOptions<DataContext> _options;
        public UsuarioRepository(DbContextOptions<DataContext> options) : base(options) => _options = options;

        public Usuario EncontrarPorLoginSenha(LoginDto dto)
        {
            using (var ctx = new DataContext(_options))
            {
                var usuario = ctx.Usuarios
                                 .FirstOrDefault(x => x.Nome == dto.Nome && x.Senha == x.Senha);

                return usuario;
            }
        }
    }
}