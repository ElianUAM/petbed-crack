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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            dtphospedaje.MinDate = DateTime.Today;
            dtpsalida.MinDate = DateTime.Today;

            dtphospedaje.ValueChanged += dtphospedaje_ValueChanged;
            dtpsalida.ValueChanged += dtpsalida_ValueChanged;

        }

        private void dtphospedaje_ValueChanged(object sender, EventArgs e)
        {
            if (dtphospedaje.Value > dtpsalida.Value)
            {
                dtpsalida.Value = dtphospedaje.Value;
            }
        }

        private void dtpsalida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpsalida.Value < dtphospedaje.Value)
            {
                dtphospedaje.Value = dtpsalida.Value;
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
            Form form2 = new Form2(this);
            this.Hide();
            form2.Text = "Datos del Cliente";
            form2.Size = new System.Drawing.Size(616, 405);
            form2.Show();


            DateTime fechaEntrada = dtphospedaje.Value;
            DateTime fechaSalida = dtpsalida.Value;


        }

       
    }
}
