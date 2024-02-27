using TNews.Data;
using TNews.Models;

namespace TNews.Services
{
    public class AutorService : IAutorService
    {
        private readonly ApplicationDbContext _context;

        public AutorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public IEnumerable<Autor> ObterTodos()
        {
            return _context.Autores.ToList();
        }

        public Autor ObterPorId(int id)
        {
            return _context.Autores.FirstOrDefault(a => a.Id == id);
        }

        public void Atualizar(Autor autor)
        {
            _context.Autores.Update(autor);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var autor = _context.Autores.Find(id);
            _context.Autores.Remove(autor);
            _context.SaveChanges();
        }
    }

}
