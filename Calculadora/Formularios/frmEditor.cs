using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Calculadora.Formularios
{
    public partial class frmEditor : Form
    {
        bool save = false;
        String path = "";
        int contPalabras = 0;
        string texto = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opfEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opfEditor.FileName))
                {
                    using (StreamReader archivo = new StreamReader(opfEditor.FileName)) ;
                    {
                        rtbEditor.Text = File.ReadAllText(opfEditor.FileName);
                    }
                }
            }
        }
        private void Guardar()
        {
            if (svfEditor.ShowDialog() == DialogResult.OK)
            {
                path = svfEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(svfEditor.FileName))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                Guardar();
                save = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svfEditor.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(svfEditor.FileName))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        private void tssEstatus_Click(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas \n\nPalabras: "+palabras.Length.ToString()
                              + "\nLetras: " + texto.Length.ToString() + "\nParrafos: "
                             + parrafos.Length.ToString(), "\nContador de Palabras");
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            tssEstatus.Text = palabras.Length.ToString() + " palabras";
        }
    }
}
