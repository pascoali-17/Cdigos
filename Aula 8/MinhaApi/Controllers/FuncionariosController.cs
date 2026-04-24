using Microsoft.AspNetCore.Mvc;
using MinhaApi.Services;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly FuncionarioService _service;

        public FuncionariosController(FuncionarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_service.ListarTodos());
        }

        [HttpGet("salario-maior-3000")]
        public IActionResult SalarioMaior3000()
        {
            return Ok(_service.SalarioMaiorQue3000());
        }

        [HttpDelete("remover-setor/{setor}")]
        public IActionResult RemoverSetor(string setor)
        {
            _service.RemoverSetor(setor);
            return NoContent();
        }

        [HttpGet("ordenar-salario")]
        public IActionResult OrdenarPorSalario()
        {
            return Ok(_service.OrdenarPorSalario());
        }

        [HttpGet("soma-salarios")]
        public IActionResult SomaSalarios()
        {
            return Ok(_service.SomarSalarios());
        }
    }
}