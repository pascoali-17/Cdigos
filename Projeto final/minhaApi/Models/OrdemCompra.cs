namespace minhaApi.Models;

public class OrdemCompra
{
    public int IdOrdemCompra { get; set; }
    public string Status { get; set; } = "Aberta";
    public List<OrdemCompraItem> Itens { get; set; } = new();
}