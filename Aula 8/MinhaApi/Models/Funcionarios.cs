namespace MinhaApi.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Setor { get; set; } = string.Empty;
        public decimal Salario { get; set; }
    }
}   