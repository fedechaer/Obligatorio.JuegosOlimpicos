
using System.ComponentModel.DataAnnotations;

namespace LibreriaWeb.Models.Usuario
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(100, ErrorMessage = "La contraseña debe tener al menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "El rol es obligatorio.")]
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; internal set; }
    }
}
