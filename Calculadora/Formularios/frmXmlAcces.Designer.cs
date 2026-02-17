namespace Calculadora.Formularios
{
    partial class frmXmlAcces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersona = new DataGridView();
            btnGuardar = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            SuspendLayout();
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvPersona.Location = new Point(-1, 2);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.Size = new Size(802, 325);
            dgvPersona.TabIndex = 0;
            dgvPersona.CellContentClick += dgvPersona_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(336, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefono";
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // frmXmlAcces
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPersona);
            Name = "frmXmlAcces";
            Text = "frmXmlAcces";
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersona;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}