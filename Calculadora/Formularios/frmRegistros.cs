using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmRegistros : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                Fecha = dtpFecha.Value
            });
            MessageBox.Show("Registro exitoso", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
                verificarRegistros();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void verificarRegistros()
        {
            if (persona.Count == 0)
                button1.Enabled = false;
            else
                btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvPersonas.CurrentRow.Index);
            dgvPersonas.DataSource = null; //Limpiar el datasource para que se refresque 
            dgvPersonas.DataSource = persona; // Volver a asignar el datasource para mostrar
            verificarRegistros();
        }
    }
}
