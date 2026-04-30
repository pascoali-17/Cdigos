namespace minhaApi.Models;

public class OrdemCompraItem
{
    public int Id { get; set; }
    public Item Item { get; set; } = new Item();
    public int Quantidade { get; set; }
}