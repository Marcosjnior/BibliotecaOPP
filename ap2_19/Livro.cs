public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public string Isbn { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string autor, string isbn, string genero, int quantidadeEmEstoque, string titulo, string codigo) : base(titulo, codigo)
    {
        Autor = autor;
        Isbn = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }


    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque -= 1;
            Console.WriteLine($"um livro foi retirado do estoque");
        }
        else
        {
            Console.WriteLine("Não ha esse livro disponivel no estoque");
        }


    }

    public override void Devolver()
    {
        QuantidadeEmEstoque += 1;
        Console.WriteLine("Livro devolvido");
    }

}