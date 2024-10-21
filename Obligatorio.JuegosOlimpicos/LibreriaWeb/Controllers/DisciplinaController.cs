using LibreriaWeb.Models.Discilpina;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.ImplementacionCasosDeUso.Usuario;
using LogicaNegocio.Entidades;
using LogicaNegocio.ValueObjects;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace LibreriaWeb.Controllers
{
    public class DisciplinaController : Controller
    {
        private static IRepositorioDisciplina RepoDisciplina;

        public DisciplinaController(IRepositorioDisciplina repoDisciplina)
        {
            RepoDisciplina = repoDisciplina;
        }
        // GET: DisciplinaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DisciplinaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisciplinaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisciplinaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DisciplinaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existeDsiciplina = RepoDisciplina.FindById(model.Id);
                if (existeDsiciplina != null)
                {
                    ModelState.AddModelError("","Existe Disciplina con ese Id");
                    return View(model);
                }

                var nombreDisciplina = new NombreDisciplina(model.NombreDescriptivo);
                var disciplina = new Disciplina 
                { 
                    NombreDescriptivo = nombreDisciplina,
                    AnioInclusion = model.AnioInclusion
                };

                RepoDisciplina.Add(disciplina);
                return RedirectToAction("Listado");
            }
            return View();
        }

        // GET: DisciplinaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisciplinaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DisciplinaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisciplinaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
