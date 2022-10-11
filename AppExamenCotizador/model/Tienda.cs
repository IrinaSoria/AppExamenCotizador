using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenCotizador.model
{
    class Tienda
    {
        public String nombre_tienda { get; set; }
        public String direccion_tienda { get; internal set; }

        public Tienda(String nombre_tienda, String direccion_tienda)
        {
            this.nombre_tienda = nombre_tienda;
            this.direccion_tienda= direccion_tienda;

        }
    }
}