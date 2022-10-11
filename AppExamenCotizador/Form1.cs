using AppExamenCotizador.controller;
using AppExamenCotizador.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExamenCotizador
{
    public partial class Form1 : Form
    {
       public  bool historial;
        public bool chupin;
        public bool radio_premiun;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CotizadorController cotizadorController = new CotizadorController(this);

            Cotizaciones cotizaciones = new Cotizaciones(this);
            cotizaciones.agregarCotizaciones(cotizaciones);
            foreach (Cotizaciones c in cotizaciones.ListCotizaciones)
            {
                Console.WriteLine(c);
            }

            

            

            String nombre_tienda = textNombre.Text;
            String direccion_tienda = textDireccion.Text;
            String nombre_vendedor = textNombreVendedor.Text;
            String codigo_vendedor = textCodigo.Text;
            Boolean chupin = checkChupin.Checked;
            
            if (radioButton1.Checked == true)
            {
                Camisa camisa = new Camisa();

            }
            if (radioButton2.Checked == true)
            {
                Pantalon pantalon = new Pantalon();
            }
            if (checkHistorial.Checked== true)
            {
                historial = true;
               


            }
            
        }

       

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radio_premiun = true;
            standar.Enabled = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            premiun.Enabled = false;
        }

       private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
