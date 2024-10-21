using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesEntidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioDisciplina : IRepositorioDisciplina
    {
        private readonly List<Disciplina> Disciplinas = new List<Disciplina>();
        public void Add(Disciplina item)
        {
            if (!Disciplinas.Contains(item))
            {
                Disciplinas.Add(item);
            }
        }

        public void Delete(int id)
        {
            Disciplina disciplina= FindById(id);
            if (disciplina == null)
            {
                throw new UsuarioException("El id recibido no es correcto");
            }
            Disciplinas.Remove(disciplina);
        }

        public IEnumerable<Disciplina> FindAll()
        {
            return Disciplinas;
        }

        public Disciplina FindById(int id)
        {
            Disciplina disciplina= null;
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

        public void Update(Disciplina item, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Disciplina> ListarDisciplinas()
        {
            return Disciplinas.OrderBy(d => d.NombreDescriptivo);
        }
    }
}
