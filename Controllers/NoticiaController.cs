using Microsoft.AspNetCore.Mvc;
using TNews.Models;
using TNews.Services;

namespace TNews.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaService _noticiaService;

        public NoticiaController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        public IActionResult Index()
        {
            var noticias = _noticiaService.ObterTodas();
            return View(noticias);
        }

        public IActionResult Details(int id)
        {
            var noticia = _noticiaService.ObterPorId(id);
            return View(noticia);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                _noticiaService.Adicionar(noticia);
                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var noticia = _noticiaService.ObterPorId(id);
            return View(noticia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                _noticiaService.Atualizar(noticia);
                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        public IActionResult Delete(int id)
        {
            var noticia = _noticiaService.ObterPorId(id);
            return View(noticia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _noticiaService.Excluir(id);
            return RedirectToAction("Index");
        }
    }

}
