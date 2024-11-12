using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petbed
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxraza.SelectedItem.ToString() == "Otro")
            {
                // Habilitar el TextBox
                txtraza.Enabled = true;
            }
            else
            {
                // Deshabilitar el TextBox si se elige otra opción
                txtraza.Enabled = false;
            }
        }


    }

}

