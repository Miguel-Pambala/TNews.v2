using Microsoft.EntityFrameworkCore;
using TNews.Data;
using TNews.Models;

namespace TNews.Services
{
    public class NoticiaService : INoticiaService
    {
        private readonly ApplicationDbContext _context;

        public NoticiaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Noticia noticia)
        {
            _context.Noticias.Add(noticia);
            _context.SaveChanges();
        }

        public IEnumerable<Noticia> ObterTodas()
        {
            return _context.Noticias.Include(n => n.Autor).Include(n => n.Categoria).ToList();
        }

        public Noticia ObterPorId(int id)
        {
            return _context.Noticias.Include(n => n.Autor).Include(n => n.Categoria).FirstOrDefault(n => n.Id == id);
        }

        public void Atualizar(Noticia noticia)
        {
            _context.Noticias.Update(noticia);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var noticia = _context.Noticias.Find(id);
            _context.Noticias.Remove(noticia);
            _context.SaveChanges();
        }
    }

}
