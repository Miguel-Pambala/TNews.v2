using TNews.Data;
using TNews.Models;

namespace TNews.Repositorios
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly ApplicationDbContext _context;

        public RepositorioCategoria(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public IEnumerable<Categoria> ObterTodas()
        {
            return _context.Categorias.ToList();
        }

        public Categoria ObterPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var categoria = _context.Categorias.Find(id);
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }
    }

    // Interface IRepositorioCategoria
    public interface IRepositorioCategoria
    {
        void Adicionar(Categoria categoria);
        IEnumerable<Categoria> ObterTodas();
        Categoria ObterPorId(int id);
        void Atualizar(Categoria categoria);
        void Excluir(int id);
    }

}
