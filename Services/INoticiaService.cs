using TNews.Models;

namespace TNews.Services
{
    public interface INoticiaService
    {
        void Adicionar(Noticia noticia);
        IEnumerable<Noticia> ObterTodas();
        Noticia ObterPorId(int id);
        void Atualizar(Noticia noticia);
        void Excluir(int id);
    }
}
