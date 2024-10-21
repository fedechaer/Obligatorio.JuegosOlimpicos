using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioDisciplina : IRepositorio<Disciplina>
    {
        public static List<Disciplina> Disciplinas = new List<Disciplina>();

        public void Add(Disciplina disciplina)
        {
            if (!Disciplinas.Contains(disciplina))
            {
                Disciplinas.Add(disciplina);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Disciplina> FindAll()
        {
            return Disciplinas;
        }

        public Disciplina FindById(int id)
        {
            Disciplina disciplina = null;
            int i = 0;
            while (i < Disciplinas.Count && disciplina == null)
            {
                if (Disciplinas[i].Id == id)
                {
                    disciplina = Disciplinas[i];
                }
                i++;
            }
            return disciplina;
        }

        public void Update(Disciplina disciplina, int id)
        {
            Disciplina disciplinaBuscado= FindById(id);
            if (disciplinaBuscado == null)
            {
                throw new UsuarioException("El id es incorrecto");
            }
            else
            {
                disciplina.Validar();
                disciplina.NombreDescriptivo = disciplinaBuscado.NombreDescriptivo;
                disciplina.AnioInclusion = disciplinaBuscado.AnioInclusion;
            }
        }
    }
}
