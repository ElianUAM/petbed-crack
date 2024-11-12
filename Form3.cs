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

        private void bttsubirimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer los filtros para solo mostrar imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                imagenperro.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }
    }

}

