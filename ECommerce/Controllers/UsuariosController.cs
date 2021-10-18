using ECommerce.Application.Interfaces;
using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerce.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioApplication _application;
        public UsuariosController(IUsuarioApplication application) => _application = application;

        [HttpGet]
        public IActionResult Get([FromQuery] string query) => Ok(_application.GetAll(query));

        [HttpGet("{id}")]
        public IActionResult Get(long id) => Ok(_application.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _application.AddOrUpdate(usuario);

                return Ok(usuario.Id);
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao gravar o usuário. Revise o preenchimento dos campos tente novamente.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Usuario usuario)
        {
            try
            {
                _application.Remove(usuario);

                return Ok();
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao deletar o usuário. Tente novamente.");
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            try
            {
                return Ok(_application.Login(dto));
            }
            catch (Exception)
            {
                throw new Exception("Usuário ou senha inválidos");
            }
        }
    }
}