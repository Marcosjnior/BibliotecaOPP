
Biblioteca biblioteca = new Biblioteca();


var livro1 = new Livro("Paulo Coelho", "978-85-325-7310-0", "Ficção", 5, "O Alquimista", "LIV001");
biblioteca.CadastrarLivro(livro1);

var livro2 = new Livro("George Orwell", "978-85-254-0760-3", "Ficção", 3, "1984", "LIV002");
biblioteca.CadastrarLivro(livro2);

var livro3 = new Livro("J.K. Rowling", "978-85-7638-063-7", "Fantasia", 2, "Harry Potter e a Pedra Filosofal", "LIV003");
biblioteca.CadastrarLivro(livro3);

string autorPesquisa = "J.K. Rowling";


List<Livro> livrosEncontrados = biblioteca.PesquisarLivrosPorAutor(autorPesquisa);
if (livrosEncontrados.Count > 0)
{
        Console.WriteLine($"Livros encontrados de {autorPesquisa}:");
        foreach (var livro in livrosEncontrados)
        {
                Console.WriteLine($"O Livro: {livro.Titulo} de {livro.Autor} foi encontrado no sistema");
        }
}
else
{
        Console.WriteLine($"Nenhum livro encontrado para o autor {autorPesquisa}.");
}



var usuario1 = new Usuario("Alice", "USR001", "Rua das Flores, 123", "alice@example.com");
biblioteca.CadastrarUsuario(usuario1);

var usuario2 = new Usuario("Bob", "USR002", "Avenida do Sol, 456", "bob@example.com");
biblioteca.CadastrarUsuario(usuario2);


biblioteca.EmprestarLivro("LIV001", "USR001");
usuario1.AdicionarEmprestimo("Empréstimo: O Alquimista");

biblioteca.EmprestarLivro("LIV002", "USR002");
usuario2.AdicionarEmprestimo("Empréstimo: 1984");


biblioteca.EmprestarLivro("LIV003", "USR002");


biblioteca.DevolverLivro("LIV001");


Console.WriteLine("\n--- Informações dos Usuários ---");
usuario1.ExibirInformacoes();
usuario1.ExibirHistorico();

Console.WriteLine();

usuario2.ExibirInformacoes();
usuario2.ExibirHistorico();


Console.WriteLine("\n--- Livros na Biblioteca ---");
biblioteca.ListarLivros();