using Microsoft.AspNetCore.Mvc;
using minhaApi.Models;
using minhaApi.Controllers;

namespace minhaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdemProducaoController : ControllerBase
{
//    private static List<OrdemCompra> ordensCompra = new();
    private static List<OrdemProducao> ordensProducao = new();

    [HttpPost("{idOrdemCompra}")]
    public IActionResult CriarOrdemProducao(int idOrdemCompra)
    {
        var ordemCompra = OrdemCompraController.ordensCompra.FirstOrDefault(o => o.IdOrdemCompra == idOrdemCompra);

        if (ordemCompra == null)
            return NotFound("Ordem de Compra não encontrada");

        if (ordemCompra.Status != "Aprovada")
            return BadRequest("Ordem de Compra não está aprovada");

        var ordemProducao = new OrdemProducao
        {
            IdOrdemProducao = ordensProducao.Count + 1,
            DataEmissao = DateTime.Now,
            DataPrevista = DateTime.Now.AddDays(5),
            Status = "Aprovada",
            ListaItens = ordemCompra.Itens.Select(i => new OrdemProducaoItem
            {
                Item = i.Item,
                Quantidade = i.Quantidade
            }).ToList()
        };

        ordemCompra.Status = "Fechada";
        ordensProducao.Add(ordemProducao);

        return Ok(ordemProducao);
    }
}