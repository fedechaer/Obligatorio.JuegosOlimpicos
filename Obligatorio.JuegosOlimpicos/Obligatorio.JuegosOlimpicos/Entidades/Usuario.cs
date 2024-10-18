using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Usuario
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        public Email Email { get; set; }
        [Required]
        public Password Password { get; set; }
        [Required]
        public Rol Rol { get; set; }

        public List<Atleta> _atletas = new List<Atleta>();

        public List<Evento> _eventos = new List<Evento>();


        private Usuario() { }
        public Usuario(string email, string password, Rol rol)
        {
            Email = new Email(email);
            Password = new Password(password);
            Rol = rol;
            Validar();
        }

       
        public void Validar()
        {
            if (!Rol.Equals("Administrador") || !Rol.Equals("Digitador"))
            {
                throw new UsuarioException("El rol no es valido");
            }
        }

        public void CreacionEvento(string nombre, DateTime fechaInicio, DateTime fechaFin)
        {
            if (_eventos.Equals(nombre))
            {
                throw new UsuarioException("Existe un evento con ese nombre");
            }
            Evento nuevoEvento = new Evento(nombre, fechaInicio, fechaFin);
            _eventos.Add(nuevoEvento);
        }
        public void AgregarDisciplina(Evento evento, Atleta atleta)
        {
            if (!atleta._eventos.Contains(evento))
            {
                atleta._eventos.Add(evento);
            }
            else
            {
                throw new Exception("Ya participa del evento");
            }
        }
        public bool Equals(Usuario? other)
        {
            return Email == other.Email;
        }
    }
}
