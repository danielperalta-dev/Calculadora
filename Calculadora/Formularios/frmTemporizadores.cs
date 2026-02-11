using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using CSCore.SoundOut;

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if(lblHora.Text == alarma1)
            {
                SoundPlayer alarma = new SoundPlayer("alarma_messi.wav");
                alarma.Play();
                MessageBox.Show("¡Alarma 1 activada!");
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la  hora de alarma 1 (formato: hh:mm:ss tt)","Sistema","00:00:00 x.x");
        }
    }
}
