using TNews.Models;

namespace TNews.Services
{
    public interface ICategoriaService
    {
        void Adicionar(Categoria categoria);
        IEnumerable<Categoria> ObterTodas();
        Categoria ObterPorId(int id);
        void Atualizar(Categoria categoria);
        void Excluir(int id);
    }
}
