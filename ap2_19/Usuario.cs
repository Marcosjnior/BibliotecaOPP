public class Usuario
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    private List<string> HistoricoEmprestimos { get; set; }

    public Usuario(string nome, string numeroidentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroidentificacao;
        Endereco = endereco;
        Contato = contato;
        HistoricoEmprestimos = new List<string>();

    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} Numero de Idetificação:{NumeroIdentificacao} Endereço: {Endereco} Contato: {Contato}");
    }

    public void ExibirHistorico()
    {
        if (HistoricoEmprestimos.Count > 0)
        {
            Console.WriteLine("Historico");
            foreach (var emprestimo in HistoricoEmprestimos)
            {
                Console.WriteLine(emprestimo);
            }
        }
        else
        {
            Console.WriteLine("não foi possivel encontar nada no historico de emprestimos");
        }

    }
    public void AdicionarEmprestimo(string emprestimo)
    {
        HistoricoEmprestimos.Add(emprestimo);
    }
}