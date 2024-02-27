namespace TNews.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        // Propriedade de navegação
        public ICollection<Noticia> Noticias { get; set; }
    }
}