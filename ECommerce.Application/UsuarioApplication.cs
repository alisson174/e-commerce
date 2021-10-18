using ECommerce.Application.Interfaces;
using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;

namespace ECommerce.Application
{
    public class UsuarioApplication : BaseApplication<Usuario>, IUsuarioApplication
    {
        private IUsuarioService _service;
        private ITokenService _tokenService;
        public UsuarioApplication(IUsuarioService service, ITokenService tokenService) : base(service)
        {
            _service = service;
            _tokenService = tokenService;
        }

        public Usuario Login(LoginDto dto)
        {
            var usuarioRecuperado = _service.EncontrarPorLoginSenha(dto);

            if (usuarioRecuperado != null)
            {
                var token = _tokenService.GerarToken(usuarioRecuperado);

                usuarioRecuperado.Token = token;
                
                // "Apaga" a senha ao retornar o usuário
                usuarioRecuperado.Senha = "";
            }

            return usuarioRecuperado;
        }
    }
}