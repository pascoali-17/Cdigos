// ===================================
// ARQUIVO: Models/OrdemCompra.cs
// ===================================

namespace MRPSystem.Models;

public class OrdemCompra
{
    public int IdOrdemCompra { get; set; }
    public DateTime DataEmissao { get; set; }
    public string Status { get; set; } = "Aberta";
    public List<OrdemCompraItem> Itens { get; set; } = new();

    public OrdemCompra()
    {
        DataEmissao = DateTime.Now;
    }
}