using Microsoft.AspNetCore.Mvc;
using TNews.Models;
using TNews.Services;

namespace TNews.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        public IActionResult Index()
        {
            var autores = _autorService.ObterTodos();
            return View(autores);
        }

        public IActionResult Details(int id)
        {
            var autor = _autorService.ObterPorId(id);
            return View(autor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Autor autor)
        {
            if (ModelState.IsValid)
            {
                _autorService.Adicionar(autor);
                return RedirectToAction("Index");
            }

            return View(autor);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var autor = _autorService.ObterPorId(id);
            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Autor autor)
        {
            if (ModelState.IsValid)
            {
                _autorService.Atualizar(autor);
                return RedirectToAction("Index");
            }

            return View(autor);
        }

        public IActionResult Delete(int id)
        {
            var autor = _autorService.ObterPorId(id);
            return View(autor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _autorService.Excluir(id);
            return RedirectToAction("Index");
        }
    }

}
