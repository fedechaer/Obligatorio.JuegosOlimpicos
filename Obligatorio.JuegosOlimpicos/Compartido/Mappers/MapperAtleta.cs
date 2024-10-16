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
    public class MapperAtleta
    {

        public static Atleta DTOAtletaToAtleta( AtletaDTO atletaDTO )
        {
            if( atletaDTO == null)
            {
                throw new AtletaException("Los datos no son correctos");
            }
            return new Atleta(atletaDTO.NombreCompleto, atletaDTO.Sexo);
        }
    
    }
}
