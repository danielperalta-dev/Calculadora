namespace Calculadora.Formularios
{
    partial class frmContador
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
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            trbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(162, 0);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(109, 128);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(114, 190);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Iniciar";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(249, 190);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 23);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // trbVelocidad
            // 
            trbVelocidad.Enabled = false;
            trbVelocidad.Location = new Point(25, 131);
            trbVelocidad.Maximum = 5;
            trbVelocidad.Minimum = 1;
            trbVelocidad.Name = "trbVelocidad";
            trbVelocidad.Size = new Size(390, 45);
            trbVelocidad.TabIndex = 3;
            trbVelocidad.Value = 1;
            trbVelocidad.Scroll += trbVelocidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 244);
            Controls.Add(trbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "frmContador";
            Load += frmContador_Load;
            ((System.ComponentModel.ISupportInitialize)trbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar trbVelocidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}