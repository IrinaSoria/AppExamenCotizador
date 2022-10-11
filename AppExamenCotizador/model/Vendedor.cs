using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenCotizador.model
{
    class Vendedor
    {
        public String nombre_vendedor { get; internal set; }
        public String codigo_vendedor { get; internal set; }
    
        public Vendedor(String nombre_vendedor, String codigo_vendedor)
        {
            this.nombre_vendedor = nombre_vendedor;
            this.codigo_vendedor = codigo_vendedor;
        }
    }
}
