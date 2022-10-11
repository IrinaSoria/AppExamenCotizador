using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExamenCotizador.model
{
    class Camisa : Prenda
    {
        private double precio_camisa;


        public Camisa() : base()
        {
        }
      public Boolean Cuello_mao { get; set; }

        public Boolean Manga_corta { get; internal set; }

        public override double calcularPrecio(Form1 form)
        {
          

            if(Cuello_mao== true)
            {
               precio_camisa=  precioBase * 0.90;
            }
            else
            {
                precio_camisa = precioBase * 0.90;

            }
          if(Manga_corta== true)
            {
                precio_camisa = precioBase * 0.90;
 
            }
            else
            {
               precio_camisa=  precioBase * 0.90;
            
            }
          if(Cuello_mao == true && Manga_corta == true)
            {
                precio_camisa = precioBase * 0.90;
                var p = precio_camisa * 1.03;
                precio_camisa = p;

              

            }
          

            return precio_camisa;


          
        }

       public override double calcularPrecioCalidad(Form1 form)
       {
            double precio_calidad = 0;
            if  (form.radio_premiun)
        {
               precio_calidad = precio_camisa * 1.3;
            }
            else
            {
                precio_calidad = precio_camisa * 1;
           }
            return precio_calidad;
        }
    }
}
