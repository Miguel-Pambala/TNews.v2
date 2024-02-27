namespace TNews.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int AutorId { get; set; }
        public int CategoriaId { get; set; }

        // Propriedades de navegação
        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
