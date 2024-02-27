using TNews.Models;

namespace TNews.Services
{
    public interface IAutorService
    {
        void Adicionar(Autor autor);
        IEnumerable<Autor> ObterTodos();
        Autor ObterPorId(int id);
        void Atualizar(Autor autor);
        void Excluir(int id);
    }
}
