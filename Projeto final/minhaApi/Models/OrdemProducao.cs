namespace minhaApi.Models;

public class OrdemProducao
{
    public int IdOrdemProducao { get; set; }
    public DateTime DataEmissao { get; set; }
    public DateTime DataPrevista { get; set; }
    public string Status { get; set; } = "Aberta";
    public Funcionario FuncionarioResponsavel { get; set; } = new();
    public List<OrdemProducaoItem> ListaItens { get; set; } = new();
}