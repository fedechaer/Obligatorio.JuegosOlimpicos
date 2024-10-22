using LibreriaWeb.Models.Atleta;
using LogicaAplicacion.ImplementacionCasosDeUso.Atleta;
using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWeb.Controllers
{
    public class AtletaController : Controller
    {
        public AltaAtleta AltaAtleta { get; set; } = new AltaAtleta();
        private readonly IRepositorioAtleta RepoAtleta;
        private readonly IRepositorioDisciplina RepoDisciplina;

        public AtletaController(IRepositorioAtleta repositorioAtleta, IRepositorioDisciplina repositorioDisciplina)
        {
            RepoAtleta = repositorioAtleta;
            RepoDisciplina = repositorioDisciplina;
        }

        public IActionResult AsignarDisciplinas(int atletaId)
        {
            
            var atleta = RepoAtleta.FindById(atletaId);
            var disciplinas = RepoDisciplina.FindAll();
            AtletaViewModel viewModel = null;
            try
            {
                viewModel = new AtletaViewModel
            {
                Id = atleta.Id,
                Nombre = atleta.Nombre,
                Apellido = atleta.Apellido,
                Disciplinas = atleta._disciplinas
            };
            }
            catch (AtletaException ex)
            {
                ViewBag.Mensaje = "Se produjo un error";
            }
            if(viewModel == null)
            {
                return RedirectToAction("ErrorPage");
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AsignarDisciplinas(AtletaViewModel model)
        {
            var atleta = RepoAtleta.FindById(model.Id);

            var NuevasDisciplinas = RepoDisciplina.FindById(model.Id);
            foreach (var disciplina in RepoDisciplina.FindAll())
            {
                if (!atleta._disciplinas.Contains(disciplina))
                {
                    atleta._disciplinas.Add(disciplina);
                }
            }

            RepoAtleta.Update(atleta, atleta.Id);
            return RedirectToAction("Index");
        }
        // GET: AtletaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtletaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtletaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtletaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AtletaViewModel atletaVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Atleta atleta = new Atleta(atletaVM.Nombre, atletaVM.Apellido, atletaVM.Sexo, atletaVM.Pais);
                    AltaAtleta.Ejecutar(atleta);
                }

                return RedirectToAction("Index");
            }
            catch (AtletaException ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Se produjo un error";
            }
            return View();
        }

        // GET: AtletaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtletaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IRepositorioAtleta RepoAtleta)
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

        // GET: AtletaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtletaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IRepositorioAtleta RepoAtleta)
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
