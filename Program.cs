using System;

// Classe base
public class Veiculo
{
    public string marca;
    public int velocidade;

    public Veiculo(string marca, int velocidade)
    {
        this.marca = marca;
        this.velocidade = velocidade;
    }

    // Método que será sobrescrito
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

// Classe Carro
public class Carro : Veiculo
{
    public Carro(string marca, int velocidade) : base(marca, velocidade)
    {
    }

    public override void Mover()
    {
        Console.WriteLine($"O carro da marca {marca} está andando a {velocidade} km/h.");
    }
}

// Classe Moto
public class Moto : Veiculo
{
    public Moto(string marca, int velocidade) : base(marca, velocidade)
    {
    }

    public override void Mover()
    {
        Console.WriteLine($"A moto da marca {marca} está correndo a {velocidade} km/h.");
    }
}

// Classe Caminhao
public class Caminhao : Veiculo
{
    public Caminhao(string marca, int velocidade) : base(marca, velocidade)
    {
    }

    public override void Mover()
    {
        Console.WriteLine($"O caminhão da marca {marca} está transportando carga a {velocidade} km/h.");
    }
}

// Classe principal com Main
class Program
{
    static void Main(string[] args)
    {
        Veiculo carro = new Carro("Chevrolet", 85);
        Veiculo moto = new Moto("Honda", 120);
        Veiculo caminhao = new Caminhao("Volvo",90 );

        carro.Mover();
        moto.Mover();
        caminhao.Mover();
    }
}

