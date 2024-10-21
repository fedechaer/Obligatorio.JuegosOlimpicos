using Compartido.DTO;
using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Mappers
{
    public class MapperDisciplina
    {
        public static Disciplina DTODisciplinaToDisciplina(DisciplinaDTO disciplinaDTO)
        {
            if (disciplinaDTO == null)
            {
                throw new AtletaException("Los datos no son correctos");
            }
            return new Disciplina(disciplinaDTO.NombreDesc, disciplinaDTO.AnioInclusion);
        }
    }
}
