using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamenCotizador.model
{
    class Pantalon : Prenda
    {
        private double precio_pantalon;

        public Pantalon() : base()
        {
            
        }
        
        public override double calcularPrecio(Form1 form)
        {
            if (form.chupin == true)
            {
                precio_pantalon = precioBase * 0.88;
            }
            return precio_pantalon;

        }

        public override double calcularPrecioCalidad(Form1 form)
        {
            double precio_calidad = 0;
            if (form.radio_premiun == true)
            {
                precio_calidad = precio_pantalon * 1.3;
            }
            else
            {
                precio_calidad = precio_pantalon * 1;
            }

            return precio_calidad;
        }
    }
}
