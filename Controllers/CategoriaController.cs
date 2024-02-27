using Microsoft.AspNetCore.Mvc;
using TNews.Models;
using TNews.Services;

namespace TNews.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var categorias = _categoriaService.ObterTodas();
            return View(categorias);
        }

        public IActionResult Details(int id)
        {
            var categoria = _categoriaService.ObterPorId(id);
            return View(categoria);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaService.Adicionar(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categoria = _categoriaService.ObterPorId(id);
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaService.Atualizar(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public IActionResult Delete(int id)
        {
            var categoria = _categoriaService.ObterPorId(id);
            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _categoriaService.Excluir(id);
            return RedirectToAction("Index");
        }
    }

}
