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
    public static class fecha
    {
        public static DateTime fechaEntrada { get; set; }
        public static DateTime fechaSalida { get; set; }
    }

    public partial class Form4 : Form
    {

       

        

        public Form4()
        {
            InitializeComponent();


           fecha.fechaEntrada = dtpentrada.Value;
           fecha.fechaSalida = dtpsalida.Value;
            
            dtpentrada.MinDate = DateTime.Today;
            dtpsalida.MinDate = DateTime.Today;

        }

        public void dtphospedaje_ValueChanged(object sender, EventArgs e)
        {
            if (dtpentrada.Value.Date < dtpsalida.Value)
            {

                if (fecha.fechaEntrada == default || fecha.fechaSalida == default)
                {
                    MessageBox.Show("Las fechas no se han configurado correctamente en el Form4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        public void dtpsalida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpsalida.Value < dtpentrada.Value)
            {
                dtpentrada.Value = dtpsalida.Value;
                if (fecha.fechaEntrada == default || fecha.fechaSalida == default)
                {
                    MessageBox.Show("Las fechas no se han configurado correctamente en el Form4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2(this, fecha.fechaEntrada, fecha.fechaSalida);
            form2.Text = "Datos del Cliente";
            form2.Size = new System.Drawing.Size(616, 405);
            form2.Show();
            this.Hide();

            

        }

       
    }
}
