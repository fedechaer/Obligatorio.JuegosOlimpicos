using LogicaNegocio.Entidades;

namespace LibreriaWeb.Models.Atleta
{
    public class AtletaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public List<Disciplina> TodasLasDisciplinas { get; set; }
        public List<int> NuevasDisciplinasId { get; set; }
    }
}
