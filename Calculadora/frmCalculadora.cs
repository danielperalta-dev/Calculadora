namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int A = 0, B = 0, resultado = 0;
                A = int.Parse(txtVariableA.Text);
                B = int.Parse(txtVariableB.Text);
                resultado = A + B;

                MessageBox.Show("El resultado de la suma es: " + resultado.ToString(),"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception) {
                MessageBox.Show("Error en la conversion de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
