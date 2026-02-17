using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculadora.Formularios
{
    public partial class frmXmlAcces : Form
    {
        public frmXmlAcces()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("root");


            for (int i = 0; i < dgvPersona.Rows.Count; i++)
            {
                xml.Add(
                    new XElement("Personas",
                    new XElement("ID", dgvPersona.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersona.Rows[i].Cells[1].Value),
                    new XElement("Apellido", dgvPersona.Rows[i].Cells[2].Value)));

            }
            try
            {
                xml.Save("Archivo.xml");
                MessageBox.Show("Archivo guardado exitosamente","sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: "+ex.Message);
            }

        }

        private void dgvPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
