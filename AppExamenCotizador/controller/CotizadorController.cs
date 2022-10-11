using AppExamenCotizador.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppExamenCotizador.controller
{
    class CotizadorController 
    {
        private Form1 form1;

        public CotizadorController(Form1 form1)
        {
            this.form1 = form1;
          
        }

        public void calcularCotizaciones(Prenda prenda)
        {

            double totalCotizaciones = prenda.calcularPrecioCalidad(form1) * prenda.cantidad;
      

           


           



        }

    }






    }

       

          
      
       


    }

