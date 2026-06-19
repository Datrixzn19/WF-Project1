using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace WF_Project1
{
    public partial class a : Form
    {
        private int _clickCount = 0; // Variable para contar los clics
        public a()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtNumero_Click(object sender, EventArgs e)
        {

        }



        private void btnCalcularEdad_Click(object sender, EventArgs e) //logica para calacular la edad 
        {

            try
            {
                //capturamos los datos de la interfaz
                string nombre = txtNombre.Text;
                string anio = txtAnio.Text;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Por favor, ingresa tu nombre.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //return para cortar el flujo 
                }


                //conversion de datos de string a int
                if (!int.TryParse(anio, out int anioNacimiento)) //si lo logra devuelve true y el valor convertido se almacena en anioNacimiento, si no lo logra devuelve false
                {
                    MessageBox.Show("Por favor, ingresa un año de nacimiento válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //return para cortar el flujo 
                }



                //logica de resultado
                //ya tenemos la edad validada 
                int anioActual = DateTime.Now.Year; //obtenemos el año actual
                int edad = anioActual - anioNacimiento; //calculamos la edad restando el año actual con el año de nacimiento


                lblResultado.Text = $"{edad} años."; //mostramos el resultado en la etiqueta lblResultado
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el formato solicitado", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            


        }
    }
}
