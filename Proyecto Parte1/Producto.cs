using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    internal class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double costo { get; set; }
        public double precioVenta { get; set; }
        public double stock { get; set; }
        public int idUsuario { get; set; }

        public Producto(int id, string descripcion, double costo, double precioVenta, double stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta= precioVenta;
            this.stock= stock;
            this.idUsuario = idUsuario;
        }


    }
}
