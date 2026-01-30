namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            lblVariableA = new Label();
            VariableB = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(70, 79);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(157, 23);
            txtVariableA.TabIndex = 0;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(70, 222);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(157, 23);
            txtVariableB.TabIndex = 1;
            // 
            // lblVariableA
            // 
            lblVariableA.AutoSize = true;
            lblVariableA.Location = new Point(76, 60);
            lblVariableA.Name = "lblVariableA";
            lblVariableA.Size = new Size(62, 15);
            lblVariableA.TabIndex = 2;
            lblVariableA.Text = "Variable A:";
            lblVariableA.Click += label1_Click;
            // 
            // VariableB
            // 
            VariableB.AutoSize = true;
            VariableB.Location = new Point(70, 204);
            VariableB.Name = "VariableB";
            VariableB.Size = new Size(62, 15);
            VariableB.TabIndex = 3;
            VariableB.Text = "Variable A:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(276, 163);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(VariableB);
            Controls.Add(lblVariableA);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Label lblVariableA;
        private Label VariableB;
        private Button btnCalcular;
    }
}
