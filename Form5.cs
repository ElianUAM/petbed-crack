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


        public Form5(DateTime entrada, DateTime salida)
        {
            InitializeComponent();
            this.fechaEntrada = entrada;
            this.fechaSalida = salida;

            txtingreso.Text = $"Fecha de Ingreso: {fechaEntrada.ToShortDateString()}";
            txtsalida.Text = $"Fecha de Salida: {fechaSalida.ToShortDateString()}";
            CalcularDias();

        }
        private Form3 formAnterior; // Para volver al formulario anterior

        public Form5(Form3 formAnterior)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
        }

        public Form5()
        {
        }

        private void CalcularDias()
        {
            int totalDias = (fechaSalida - fechaEntrada).Days;
            txtdias.Text = totalDias.ToString();

            if (totalDias <= 0)
            {
                MessageBox.Show("La fecha de salida debe ser mayor a la fecha de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
