// ===========================================
// ARQUIVO: Models/OrdemProducaoItem.cs
// ===========================================

namespace MRPSystem.Models;

public class OrdemProducaoItem
{
    public Item Item { get; set; } = new();
    public int Quantidade { get; set; }
}