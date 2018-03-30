using Livraria.Entities;
using Livraria.Facade;
using System.Net;
using System.Web.Mvc;

namespace Livraria.Web.Controllers
{
    public class LivroController : Controller
    {
        private LivroFacade fac;

        public LivroController()
        {
            fac = new LivroFacade();
        }

        [Authorize]
        public ActionResult Index()
        {
            return View(fac.Listar());
        }

        public ActionResult Projeto(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Livro Livro = fac.Obter(id.Value);
            if (Livro == null)
            {
                return HttpNotFound();
            }

            return View();
        }

        [Authorize]
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Livro Livro = fac.Obter(id.Value);
            if (Livro == null)
            {
                return HttpNotFound();
            }
            return View(Livro);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livro Livro)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                fac.Salvar(Livro);
                return RedirectToAction("Index");
            }

            return View(Livro);
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            fac.Excluir(id.Value);
            return RedirectToAction("Index");
        }
    }
}