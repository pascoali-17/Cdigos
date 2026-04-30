using Microsoft.AspNetCore.Mvc;
using minhaApi.Models;
using System.Collections.Generic;

namespace minhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdemCompraController : ControllerBase
    {
        public static List<OrdemCompra> ordensCompra = new();

        [HttpPost]
        public IActionResult Criar(OrdemCompra ordemCompra)
        {
            ordensCompra.Add(ordemCompra);
            return Ok(ordemCompra);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ordensCompra);
        }
    }
}