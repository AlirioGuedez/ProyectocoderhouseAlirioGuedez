using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasenia { get; set; }
        public string email { get; set; }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.email = email;
        }
    }

}
