namespace DelfinaRey_Ej.Prototipos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            string inputDNI = textBoxDNI.Text;

            // Verificar si el texto ingresado es un n�mero
            if (int.TryParse(inputDNI, out int dni))
            {
                // Validar que el DNI est� en el rango correcto
                if (dni >= 1 && dni <= 99999999)
                {
                    MessageBox.Show("DNI v�lido.", "Resultado de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El DNI ingresado est� fuera del rango permitido (1 a 99999999).", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no es v�lido. Debe ser un n�mero.", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void buttonDNI_Click(object sender, EventArgs e)
        {

        }


    }



}
