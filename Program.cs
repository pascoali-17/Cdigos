using System;

public class Produto
{
    private string nome = "";
    private double preco;
    private int estoque;

    public void DefinirNome(string novoNome)
    {
        if (!string.IsNullOrEmpty(novoNome))
        {
            nome = novoNome;
        }
    }

    public void DefinirPreco(double novoPreco)
    {
        if (novoPreco >= 0)
        {
            preco = novoPreco;
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            estoque += quantidade;
        }
    }

    public bool Vender(int quantidade)
    {
        if (quantidade > 0 && quantidade <= estoque)
        {
            estoque -= quantidade;
            return true;
        }
        return false;
    }

    public string ObterNome()
    {
        return nome;
    }

    public double ObterPreco()
    {
        return preco;
    }

    public int ObterEstoque()
    {
        return estoque;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        p.DefinirNome("Caneta");
        p.DefinirPreco(-3.50);
        p.AdicionarEstoque(20);
        p.Vender(5);

        Console.WriteLine("Nome: " + p.ObterNome());
        Console.WriteLine("Preço: " + p.ObterPreco());
        Console.WriteLine("Estoque: " + p.ObterEstoque());
    }
}