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


        public Form5(Form3 form3, DateTime fechaEntrada, DateTime fechaSalida)
        {
            InitializeComponent();

            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;

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


        private void CalcularDias()
        {
            int totalDias = (fechaSalida - fechaEntrada).Days;

            // Verifica si la fecha de salida es antes de la de entrada
            if (totalDias <= 0)
            {
                MessageBox.Show("La fecha de salida debe ser mayor a la fecha de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdias.Text = "0"; // Evitar mostrar un número negativo o incorrecto
            }
            else
            {
                txtdias.Text = totalDias.ToString();
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
