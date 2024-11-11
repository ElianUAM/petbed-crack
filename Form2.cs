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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumper.Text, out int numero))
            {
                // Validar que el número sea positivo
                if (numero > 0)
                {
                    // Crear los formularios dinamicamente
                    for (int i = 0; i < numero; i++)
                    {
                        // Crear un nuevo formulario
                        Form form3 = new Form3();
                        form3.Text = "Formulario " + (i + 1);
                        form3.Size = new System.Drawing.Size(616, 405);

                       
                        // Mostrar el formulario dinámico
                        form3.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número mayor que 0.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

