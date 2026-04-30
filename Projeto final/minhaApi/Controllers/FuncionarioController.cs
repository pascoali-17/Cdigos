using Microsoft.AspNetCore.Mvc;
using minhaApi.Models;
using System.Collections.Generic;

namespace minhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private static List<Funcionario> funcionarios = new();

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            return Ok(funcionario);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(funcionarios);
        }
    }
}