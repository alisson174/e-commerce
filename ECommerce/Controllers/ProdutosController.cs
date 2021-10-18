using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerce.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IProdutoApplication _application;
        public ProdutosController(IProdutoApplication application) => _application = application;

        [HttpGet]
        public IActionResult Get([FromQuery] string query) => Ok(_application.GetAll(query));

        [HttpGet("{id}")]
        public IActionResult Get(long id) => Ok(_application.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                _application.AddOrUpdate(produto);

                return Ok(produto.Id);
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao gravar o produto. Revise o preenchimento dos campos  tente novamente.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Produto produto)
        {
            try
            {
                _application.Remove(produto);

                return Ok();
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao deletar o produto. Tente novamente.");
            }
        }
    }
}