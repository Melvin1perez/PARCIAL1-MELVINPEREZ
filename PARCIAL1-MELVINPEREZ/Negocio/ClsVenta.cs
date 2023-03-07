using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL1_MELVINPEREZ.Negocio
{
    public class ClsVenta
    {
        public void Cobro(Venta venta)
        {
            decimal total = venta.PrecioDelProducto * venta.CantidadDeProducto;

            // Aplicar descuento si el total de la venta es mayor a $50
            if (total > 50)
            {
                total -= 10;
                Console.WriteLine($"Precio original: ${venta.PrecioDelProducto * venta.CantidadDeProducto}");
                Console.WriteLine($"Descuento aplicado: $10");
                Console.WriteLine($"Total a pagar: ${total}");
            }
            else
            {
                Console.WriteLine($"Total a pagar: ${total}");
            }
        }
    }
}
