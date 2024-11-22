using petbedcrack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petbed
{

    
    public partial class Form2 : Form
    {
        DateTime fechaEntrada;
        DateTime fechaSalida;

        private Form4 formanterior;
        public Form2(Form4 formanterior, DateTime fechaEntrada, DateTime fechaSalida)
        {
            InitializeComponent();
            this.formanterior = formanterior;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;


        }

      

        [Serializable]


        public class FormData
        {
            public string txtnombrecompleto { get; set; }
            public string txtcel { get; set; }
            public string txtemail { get; set; }
            public string txtdireccion { get; set; }
            public string txtcontacto { get; set; }
            public string txtnumperros { get; set; }

        }

        public void GuardarDatos()
        {
            // Crear una instancia de la clase FormData
            FormData Datos_Clientes = new FormData
            {
                txtnombrecompleto = txtnomb.Text ,
                txtcel = txttelefono.ToString() ,
                txtemail = txtemail.ToString() ,
                txtdireccion = txtdire.ToString() ,
                txtcontacto = txtctc1.ToString() ,
                txtnumperros = txtnumper.ToString() ,
                
            };

            // Crear un objeto BinaryFormatter para serializar los datos
            BinaryFormatter formatter = new BinaryFormatter();

            // Usar un archivo para guardar los datos
            using (FileStream stream = new FileStream("Datos_Clientes.bin", FileMode.Create))
            {
                formatter.Serialize(stream, Datos_Clientes); // Serializa el objeto 'data' y lo guarda en el archivo
            }

            
        }


        public void CargarDatos()
        {
            if (File.Exists("Datos_Clientes.bin"))
            {
                // Crear un objeto BinaryFormatter para deserializar los datos
                BinaryFormatter formatter = new BinaryFormatter();

                // Abrir el archivo donde se guardaron los datos
                using (FileStream stream = new FileStream("Datos_Clientes.bin", FileMode.Open))
                {
                    // Deserializar el archivo y convertirlo de nuevo a un objeto 'FormData'
                    FormData data = (FormData)formatter.Deserialize(stream);

                    // Restaurar los valores en los controles
                   txtnomb.Text = data.txtnombrecompleto;
                   txttelefono.Text = data.txtcel;
                   txtemail.Text = data.txtemail;
                   txtdire.Text = data.txtdireccion;
                   txtctc1.Text = data.txtcontacto;
                   txtnumper.Text = data.txtnumperros;
                }

                MessageBox.Show("Datos cargados con éxito.");
            }
            else
            {
                MessageBox.Show("No se encontraron datos guardados.");
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int totalformularios;
        private int formularioscreados;



        private void registrar(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumper.Text, out totalformularios) && totalformularios > 0)
            {
                formularioscreados = 0;
                crearformulario();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un numero válido");
            }


        }
        
        private void crearformulario()
        {
            if (formularioscreados < totalformularios)
            {
                
                Form3 form3 = new Form3(this, fechaEntrada, fechaSalida);
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        



        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mostrar mensaje de error usando ErrorProvider
                errorProvider1.SetError(txttelefono, "Solo se permiten números");
                e.Handled = true; // Anula la tecla
            }
            else
            {
                // Limpiar el mensaje de error si la entrada es válida
                errorProvider1.SetError(txttelefono, "");
            }
        }

        private void txtnumper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mostrar mensaje de error usando ErrorProvider
                errorProvider2.SetError(txtnumper, "Solo se permiten números");
                e.Handled = true; // Anula la tecla
            }
            else
            {
                // Limpiar el mensaje de error si la entrada es válida
                errorProvider2.SetError(txtnumper, "");
            }
        }

        private void txtnomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Anula la tecla para evitar que se muestre en el TextBox
                errorProvider3.SetError(txtnomb, "Solo se permiten letras");
                e.Handled = true;
                
            }
            else
            { 
                errorProvider3.SetError(txtnomb, "");
            
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtemail.Text.Contains("@"))
            {
                // Mostrar el error si no contiene '@'
                errorProvider4.SetError(txtemail, "Ingrese un correo válido");
            }
            else
            {
                // Limpiar el mensaje de error si contiene '@'
                errorProvider4.SetError(txtemail, "");
            }
        }

       
            
        private void bttContinuar (object sender, EventArgs e)
        {
            this.Hide();
            formanterior.Show();
        }
    }
}

