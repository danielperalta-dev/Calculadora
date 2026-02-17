using Calculadora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();
        }

        private void ordenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja Burbuja = new frmBurbuja();
            Burbuja.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistros registros = new frmRegistros();
            registros.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizadores reloj = new frmTemporizadores();
            reloj.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContador contador = new frmContador();
            contador.Show();
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXmlAcces xml =  new frmXmlAcces();
            xml.Show();
        }
    }
}
