using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenCotizador.model
{
    abstract class Prenda
    {
      
       
        public int precioBase { get; internal set; }
        public int cantidad { get; internal set; }


        public Prenda( int precioBase, int cantidad)
        {
            
            this.precioBase = precioBase;
            this.cantidad = cantidad;



        }

        public abstract double calcularPrecio( Form1 form);
        public abstract double calcularPrecioCalidad(Form1  form);

    }

}
