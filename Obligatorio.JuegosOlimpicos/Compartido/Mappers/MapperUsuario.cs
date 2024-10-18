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
    public class MapperUsuario
    {

        public static Usuario DTOUsuarioToUsuario(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                throw new UsuarioException("Los datos no son correctos");
            }
            return new Usuario(usuarioDTO.Email, usuarioDTO.Password, usuarioDTO.Rol);
        }
    }
}
