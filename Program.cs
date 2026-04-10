using System;

class Item
{
    public string Nome { get; set; }
    public string Tamanho { get; set; }
    public string Cor { get; set; }
    public string Uso { get; set; }
    public int Valor { get; set; }

    public void Apresentar()
    {
        Console.WriteLine(
            $"Olá, preciso de um {Nome} que tenha o tamanho {Tamanho}, na cor {Cor}, para uso {Uso} e com o valor {Valor}."
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item();
        item1.Nome = "Cadeira";
        item1.Tamanho = "médio";
        item1.Cor = "vermelha";
        item1.Uso = "diário";
        item1.Valor = 150;

        item1.Apresentar();
    }
}