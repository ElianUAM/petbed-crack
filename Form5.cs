using petbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petbedcrack
{
    public partial class Form5 : Form
    {
       DateTime fechaEntrada;
       DateTime fechaSalida;
        private Form4 form4broderl;


        public Form5(Form3 form3, DateTime fechaEntrada, DateTime fechaSalida, Form4 form4broder)
        {
            InitializeComponent();

            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.form4broderl = form4broder;


            txtingreso.Text = $"Fecha de Ingreso: {fecha.fechaEntrada.ToString("dd/MM/yyyy")}";
            txtsalida.Text = $"Fecha de Salida: {fecha.fechaSalida.ToString("dd/MM/yyyy")}";
            CalcularDias();

        }
        private Form3 formAnterior; // Para volver al formulario anterior

        public Form5(Form3 formAnterior)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
        }

        public Form5(Form3 formAnterior, DateTime fechaEntrada, DateTime fechaSalida) : this(formAnterior)
        {
        }


        public int totaldias = 0;

        public void CalcularCostos() 
        {
         double hnormal = 15;
         double hgrande = 20;
         double hvip = 25;
         double total = 0;
        
            if (form4broderl.HGRANDE.Checked)
            {
               total = totaldias * 20 ;
            }

         }



        

        private void CalcularDias()
        {
            totaldias = (fechaSalida - fechaEntrada).Days;

            // Verifica si la fecha de salida es antes de la de entrada
            if (totaldias <= 0)
            {
                MessageBox.Show("La fecha de salida debe ser mayor a la fecha de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdias.Text = "0"; // Evitar mostrar un número negativo o incorrecto
            }
            else
            {
                txtdias.Text = totaldias.ToString();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
