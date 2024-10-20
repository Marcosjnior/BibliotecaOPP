public interface IPesquisavel
{
    List<ItemBiblioteca> PesquisarPorTitulo(string Titulo);
    List<ItemBiblioteca> PesquisarPorAutor(string Autor);
    List<ItemBiblioteca> PesquisarPorGenero(string Genero);
    List<Usuario> PesquisarPorNome(string nome);

}