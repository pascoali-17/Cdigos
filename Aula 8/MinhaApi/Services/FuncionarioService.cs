using MinhaApi.Models;

namespace MinhaApi.Services
{
    public class FuncionarioService
    {
        private readonly List<Funcionario> _funcionarios = new()
        {
            new Funcionario { Id = 1, Nome = "Ana", Setor = "TI", Salario = 4500 },
            new Funcionario { Id = 2, Nome = "Bruno", Setor = "RH", Salario = 2800 },
            new Funcionario { Id = 3, Nome = "Carlos", Setor = "Financeiro", Salario = 5200 },
            new Funcionario { Id = 4, Nome = "Daniela", Setor = "TI", Salario = 3100 },
            new Funcionario { Id = 5, Nome = "Eduardo", Setor = "Vendas", Salario = 2600 }
        };

        public List<Funcionario> ListarTodos()
        {
            return _funcionarios;
        }

        public List<Funcionario> SalarioMaiorQue3000()
        {
            return _funcionarios
                .Where(f => f.Salario > 3000)
                .ToList();
        }

        public void RemoverSetor(string setor)
        {
            _funcionarios.RemoveAll(f => f.Setor == setor);
        }

        public List<Funcionario> OrdenarPorSalario()
        {
            return _funcionarios
                .OrderBy(f => f.Salario)
                .ToList();
        }

        public decimal SomarSalarios()
        {
            return _funcionarios.Sum(f => f.Salario);
        }
    }
}