using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    internal class ProductoVendido
    {
       public int id { get; set; }
       public int idProducto { get; set; }
       public double stock { get; set; }
       public int idVenta { get; set; }
       
       public ProductoVendido(int id, int idProducto, double stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }
    }
}
