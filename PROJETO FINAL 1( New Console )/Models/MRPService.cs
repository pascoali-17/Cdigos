// ======================================
// ARQUIVO: Services/MRPService.cs
// ======================================

using MRPSystem.Models;

namespace MRPSystem.Services;

public class MRPService
{
    public List<OrdemCompra> OrdensCompra { get; set; } = new();
    public List<OrdemProducao> OrdensProducao { get; set; } = new();

    // Criar Ordem de Compra
    public void CriarOrdemCompra()
    {
        OrdemCompra ordemCompra = new();

        Console.Write("ID da Ordem de Compra: ");
        ordemCompra.IdOrdemCompra = int.Parse(Console.ReadLine()!);

        Console.Write("Descrição do Item: ");
        string descricao = Console.ReadLine()!;

        Console.Write("Unidade de Medida: ");
        string unidade = Console.ReadLine()!;

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Item item = new()
        {
            IdItem = 1,
            Descricao = descricao,
            UnidadeMedida = unidade
        };

        ordemCompra.Itens.Add(new OrdemCompraItem
        {
            Item = item,
            Quantidade = quantidade
        });

        OrdensCompra.Add(ordemCompra);

        Console.WriteLine("\nOrdem de Compra criada com sucesso!");
    }

    // Listar Ordens de Compra
    public void ListarOrdensCompra()
    {
        Console.WriteLine("\n===== ORDENS DE COMPRA =====");

        foreach (var oc in OrdensCompra)
        {
            Console.WriteLine($"OC: {oc.IdOrdemCompra} | Status: {oc.Status}");
        }
    }

    // Criar Ordem de Produção
    public void CriarOrdemProducao()
    {
        Console.Write("\nInforme o ID da Ordem de Compra: ");
        int id = int.Parse(Console.ReadLine()!);

        var ordemCompra = OrdensCompra
            .FirstOrDefault(o => o.IdOrdemCompra == id);

        if (ordemCompra == null)
        {
            Console.WriteLine("Ordem de Compra não encontrada!");
            return;
        }

        OrdemProducao op = new()
        {
            IdOrdemProducao = OrdensProducao.Count + 1,
            Status = "Aberta",
            FuncionarioResponsavel = new Funcionario
            {
                IdFuncionario = 1,
                Nome = "João",
                Cargo = "Planejador"
            }
        };

        foreach (var item in ordemCompra.Itens)
        {
            op.ListaItens.Add(new OrdemProducaoItem
            {
                Item = item.Item,
                Quantidade = item.Quantidade
            });
        }

        ordemCompra.Status = "Fechada";

        OrdensProducao.Add(op);

        Console.WriteLine("\nOrdem de Produção criada com sucesso!");
    }

    // Listar Ordens de Produção
    public void ListarOrdensProducao()
    {
        Console.WriteLine("\n===== ORDENS DE PRODUÇÃO =====");

        foreach (var op in OrdensProducao)
        {
            Console.WriteLine($"OP: {op.IdOrdemProducao} | Status: {op.Status}");
        }
    }
}