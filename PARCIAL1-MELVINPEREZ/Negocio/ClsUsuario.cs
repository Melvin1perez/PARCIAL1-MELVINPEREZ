using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL1_MELVINPEREZ.Negocio
{
    public class ClsUsuario
    {
        public bool Acceso(string nombre, string contra)
        {
            // Verificar las creden del usuario
            return nombre == "TUNOMBRE" && contra == "123";
        }
    }

}