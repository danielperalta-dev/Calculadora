namespace Calculadora.Formularios
{
    partial class frmTemporizadores
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            mnsAlarma = new MenuStrip();
            EstablecerAlarmaToMenuStrip1 = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            mnsAlarma.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(32, 38);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(286, 55);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 x.x";
            lblHora.Click += lblHora_Click;
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // mnsAlarma
            // 
            mnsAlarma.Items.AddRange(new ToolStripItem[] { EstablecerAlarmaToMenuStrip1 });
            mnsAlarma.Location = new Point(0, 0);
            mnsAlarma.Name = "mnsAlarma";
            mnsAlarma.Size = new Size(357, 24);
            mnsAlarma.TabIndex = 1;
            mnsAlarma.Text = "menuStrip1";
            // 
            // EstablecerAlarmaToMenuStrip1
            // 
            EstablecerAlarmaToMenuStrip1.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem });
            EstablecerAlarmaToMenuStrip1.Name = "EstablecerAlarmaToMenuStrip1";
            EstablecerAlarmaToMenuStrip1.Size = new Size(111, 20);
            EstablecerAlarmaToMenuStrip1.Text = "Establecer alarma";
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(180, 22);
            alarma1ToolStripMenuItem.Text = "Alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 128);
            Controls.Add(lblHora);
            Controls.Add(mnsAlarma);
            MainMenuStrip = mnsAlarma;
            Name = "frmTemporizadores";
            Text = "Reloj";
            mnsAlarma.ResumeLayout(false);
            mnsAlarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip mnsAlarma;
        private ToolStripMenuItem EstablecerAlarmaToMenuStrip1;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
    }
}