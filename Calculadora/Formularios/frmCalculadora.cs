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
                if (rdbSuma.Checked)
                    resultado = A + B;
                if (rdbResta.Checked)
                    resultado = A - B;
                if (rdbMultiplicacion.Checked)
                    resultado = A * B;
                if (rdbDivision.Checked)
                    resultado = A / B;

                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //reset();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();

        }
        private void reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
