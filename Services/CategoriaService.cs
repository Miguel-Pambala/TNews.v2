using TNews.Data;
using TNews.Models;

namespace TNews.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
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
            return _context.Categorias.FirstOrDefault(c => c.Id == id);
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

}
