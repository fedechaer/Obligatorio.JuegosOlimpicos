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
            return new Atleta(atletaDTO.Nombre,atletaDTO.Apellido,atletaDTO.Sexo);
        }

        public static IEnumerable<AtletaListadoDTO> ListAtletaToListAtletaDTO(IEnumerable<Atleta>Atletas)
        {
            return Atletas.Select(static a => new AtletaListadoDTO()
            {
                Nombre = a.Nombre,
                Apellido = a.Apellido,
                Sexo = a.Sexo,
                Pais = a.Pais,
                Evento = a.Evento
            });
        }

    
    }
}
