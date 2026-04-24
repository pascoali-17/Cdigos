using MinhaApi.Models;

namespace MinhaApi.Services
{
    public class PessoaService
    {
        private readonly List<Pessoa> _pessoas = new();
        private int _id = 1;

        public List<Pessoa> ObterTodos()
        {
            return _pessoas;
        }

        public Pessoa Criar(Pessoa pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new ArgumentException("O nome não pode ser vazio.");

            if (pessoa.Idade < 0)
                throw new ArgumentException("A idade não pode ser negativa.");

            pessoa.Id = _id++;
            _pessoas.Add(pessoa);

            return pessoa;
        }
    }
}