using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmContador : Form
    {
        int contador = 0;
        public frmContador()
        {
            InitializeComponent();
        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = true;
            tmrContador.Interval = trbVelocidad.Value * 200;
            trbVelocidad.Enabled = true;
            tmrContador.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            trbVelocidad.Enabled = false;
        }

        private void trbVelocidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = trbVelocidad.Value * 200;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblCuenta.Text = contador.ToString();
        }
    }
}
