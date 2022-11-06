using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    public class Venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }
        public int idUsuarios { get; set; }
        
        public Venta(int id, string comentarios, int idUsuarios)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuarios = idUsuarios;

        }
    }
}
