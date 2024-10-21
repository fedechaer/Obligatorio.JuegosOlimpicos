using System.ComponentModel.DataAnnotations;

namespace LibreriaWeb.Models.Discilpina
{
    public class DisciplinaViewModel
    {
        [Required(ErrorMessage = "El código es obligatorio.")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El nombre debe tener entre 10 y 50 caracteres.")]
        public string NombreDescriptivo { get; set; }
        public int AnioInclusion { get; set; }
    }
}
