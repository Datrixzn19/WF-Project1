namespace WF_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            MessageBox.Show("Hello, " + name + "!");
            //txtNombre.Text = ""; //limpiamos el cuadro de texto 
            txtNombre.Clear(); //forma mas semantica 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
