using LibreriaWeb.Models.Usuario;
using LogicaAplicacion.ImplementacionCasosDeUso.Usuario;
using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public AltaUsuario AltaUsuario { get; set; } = new AltaUsuario();
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        

        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuarioVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario usuario = new Usuario(usuarioVM.Email, usuarioVM.Password, usuarioVM.Rol);
                    AltaUsuario.Ejecutar(usuario);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (UsuarioException ex)
            {   
                ViewBag.Mensaje = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Se produjo un error";
            }
            return View();

        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
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

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            ListaUsuarioViewModel usuarioViewModel = new ListaUsuarioViewModel();


            return View(usuarioViewModel);
        }

        // POST: UsuarioController/Delete/5
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


        //POST : Usuario/Login
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Usuario/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(string.Empty, "Login inválido.");
            }
            return View(model);
        }

        // GET: Usuario/Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult AccesoDenegado()
        {
            return View();
        }
    }
}
