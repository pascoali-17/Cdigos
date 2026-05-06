namespace MRPSystem.Models;

public class OrdemCompraItem
{
    public Item Item { get; set; } = new();
    public int Quantidade { get; set; }
}