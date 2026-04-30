namespace minhaApi.Models;

public class OrdemProducaoItem
{
    public int Id { get; set; }
    public Item Item { get; set; } = new();
    public int Quantidade { get; set; }
}