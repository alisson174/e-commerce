using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerce.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoApplication _application;
        public PedidosController(IPedidoApplication application) => _application = application;

        [HttpGet]
        public IActionResult Get([FromQuery] string query) => Ok(_application.GetAll(query));

        [HttpGet("{id}")]
        public IActionResult Get(long id) => Ok(_application.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                _application.AddOrUpdate(pedido);

                return Ok(pedido.Id);
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao gravar o pedido. Revise o preenchimento dos campos  tente novamente.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Pedido pedido)
        {
            try
            {
                _application.Remove(pedido);

                return Ok();
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao deletar o pedido. Tente novamente.");
            }
        }

        [HttpGet("listar-ordenado")]
        public IActionResult ListarPorDataCriacao(int quantidade)
        {
            try
            {
                _application.ListarPorDataCriacao(quantidade);
                
                return Ok();
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao listar os pedidos. Tente novamente.");
            }
        }
    }
}