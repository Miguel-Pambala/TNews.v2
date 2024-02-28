namespace TNews.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }

        // Propriedade de navegação
        public ICollection<Noticia> Noticias { get; set; }
    }
}