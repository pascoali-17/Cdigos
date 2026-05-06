// ===============================
// ARQUIVO: Program.cs
// ===============================

using MRPSystem.Services;

MRPService service = new();

int opcao = 0;

while (opcao != 5)
{
    Console.WriteLine("\n===== SISTEMA MRP =====");
    Console.WriteLine("1 - Criar Ordem de Compra");
    Console.WriteLine("2 - Listar Ordens de Compra");
    Console.WriteLine("3 - Criar Ordem de Produção");
    Console.WriteLine("4 - Listar Ordens de Produção");
    Console.WriteLine("5 - Sair");

    Console.Write("\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            service.CriarOrdemCompra();
            break;

        case 2:
            service.ListarOrdensCompra();
            break;

        case 3:
            service.CriarOrdemProducao();
            break;

        case 4:
            service.ListarOrdensProducao();
            break;

        case 5:
            Console.WriteLine("Encerrando sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
