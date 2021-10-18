using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerce.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EquipesController : Controller
    {
        private readonly IEquipeApplication _application;
        public EquipesController(IEquipeApplication application) => _application = application;

        [HttpGet]
        public IActionResult Get([FromQuery] string query) => Ok(_application.GetAll(query));

        [HttpGet("{id}")]
        public IActionResult Get(long id) => Ok(_application.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] Equipe equipe)
        {
            try
            {
                _application.AddOrUpdate(equipe);

                return Ok(equipe.Id);
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao gravar a equipe. Revise o preenchimento dos campos tente novamente.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Equipe equipe)
        {
            try
            {
                _application.Remove(equipe);

                return Ok();
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao deletar a equipe. Tente novamente.");
            }
        }
    }
}