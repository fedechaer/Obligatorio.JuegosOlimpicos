using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public static int UltId;
        public Email Email { get; set; }
        public Password Password { get; set; }
        public string Rol { get; set; }

        public List<Atleta> _atletas = new List<Atleta>();

        public List<Evento> _eventos = new List<Evento>();

        public Usuario(string email, string password, string rol)
        {
            Email = new Email(email);
            Password = new Password(password);
            Rol = rol;
            Validar();
        }

       
        public void Validar()
        {
            if (!Rol.Trim().ToUpper().Equals("Administrador") || !Rol.Trim().ToUpper().Equals("Digitador"))
            {
                throw new UsuarioException("El rol no es valido");
            }
        }

        public virtual void CreacionEvento() { }
        public virtual void AgregarDisciplina(Evento evento, Atleta atleta) { }


    }
}
