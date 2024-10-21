using LibreriaWeb.Models.Atleta;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWeb.Controllers
{
    [Authorize(Roles = "Digitador")]

    public class AtletaController : Controller
    {

        
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
            var viewModel = new AtletaViewModel
            {
                Id = atleta.Id,
                Nombre = atleta.Nombre,
                Apellido = atleta.Apellido,
                Disciplinas = atleta._eventos[Disciplina]
            };

                return View(viewModel);
            }

            [HttpPost]
            public IActionResult AsignarDisciplinas(AtletaViewModel model)
            {
                var atleta = RepoAtleta.FindById(model.Id);

                var nuevasDisciplinas = RepoDisciplina.FindById(model.Disciplinas.id);
            foreach (var disciplina in RepoDisciplina.FindAll())
                {
                    if (!atleta._eventos.Disciplina.Contains(disciplina))
                    {
                        atleta._eventos.Add(disciplina);
                    }
                }

                RepoAtleta.Update(atleta, atleta.Id);
                return RedirectToAction("Index");
            }
    }
}

