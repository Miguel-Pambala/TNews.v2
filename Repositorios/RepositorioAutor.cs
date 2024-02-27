using TNews.Data;
using TNews.Models;

namespace TNews.Repositorios
{
    public class RepositorioAutor : IRepositorioAutor
    {
        private readonly ApplicationDbContext _context;

        public RepositorioAutor(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public IEnumerable<Autor> ObterTodas()
        {
            return _context.Autores.ToList();
        }

        public Autor ObterPorId(int id)
        {
            return _context.Autores.Find(id);
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

    // Interface IRepositorioAutor
    public interface IRepositorioAutor
    {
        void Adicionar(Autor autor);
        IEnumerable<Autor> ObterTodas();
        Autor ObterPorId(int id);
        void Atualizar(Autor autor);
        void Excluir(int id);
    }

}
