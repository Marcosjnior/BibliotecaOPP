public class Biblioteca
{

    private List<Livro> Livros { get; set; } = new List<Livro>();
    private List<Usuario> Usuarios { get; set; } = new List<Usuario>();


    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro {livro.Titulo} cadastrado com sucesso");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuario {usuario.Nome} cadastrado com sucesso");
    }


    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine(livro);
        }
    }
    public void ListarUsuarios()
    {
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine(usuario);
        }
    }

    public List<Livro> PesquisarLivrosPorTitulo(string titulo)
    {
        return Livros.Where(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarLivrosPorAutor(string autor)
    {
        return Livros.Where(l => l.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarLivrosPorGenero(string genero)
    {
        return Livros.Where(l => l.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Usuario> PesquisarUsuariosPorNome(string nome)
    {
        return Usuarios.Where(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }



    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        Livro livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro, StringComparison.OrdinalIgnoreCase));
        Usuario usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao.Equals(numeroUsuario, StringComparison.OrdinalIgnoreCase));
        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            return;
        }

        livro.Emprestar(usuario);
    }


    public void DevolverLivro(string codigoLivro)
    {
        Livro livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro, StringComparison.OrdinalIgnoreCase));

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        livro.Devolver();

    }
}
