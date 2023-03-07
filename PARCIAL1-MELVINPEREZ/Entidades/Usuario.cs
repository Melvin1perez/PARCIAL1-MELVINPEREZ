using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL1_MELVINPEREZ.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contra { get; set; }
    }

    public class VENTA
    {
        public int IdentificadorDeProducto { get; set; }
        public string NombreDelProducto { get; set; }
        public string DescripcionDelProducto { get; set; }
        public decimal PrecioDelProducto { get; set; }
        public int CantidadDeProducto { get; set; }
    }

}