using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenCotizador.model
{
    class Cotizaciones
    {

        public int Id { get; set; }
        public DateTime Fechayhora { get; set; }
        public List<Cotizaciones> ListCotizaciones { get; set; }


        public Cotizaciones(int id, DateTime fechayhora, String totalCotizacion, String nombre_tienda, String direccion_tienda, String nombre_vendedor, String codigo_vendedor, Vendedor vendedor, Tienda tienda)
        {

            this.Id = id;
            this.Fechayhora = fechayhora;

            vendedor.codigo_vendedor = codigo_vendedor;
            vendedor.nombre_vendedor = nombre_vendedor;
            tienda.nombre_tienda = nombre_tienda;
            tienda.direccion_tienda = direccion_tienda;

        }
        public void agregarCotizaciones(Cotizaciones c)
        {
            ListCotizaciones.Add(c);
        }
    }
}
