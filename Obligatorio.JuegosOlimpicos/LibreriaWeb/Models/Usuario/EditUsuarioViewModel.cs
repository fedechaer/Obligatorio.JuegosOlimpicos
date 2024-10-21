using LogicaNegocio.ValueObjects;

namespace LibreriaWeb.Models.Usuario
{
    public class EditUsuarioViewModel
    {
        public Email Email { get; set; }
        public Password Password { get; set; }
        public string Rol { get; set; }
    }
}
