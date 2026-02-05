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
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            groupBox1.SuspendLayout();
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
            btnCalcular.Location = new Point(465, 114);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(465, 185);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(259, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 124);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(12, 90);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(67, 19);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(12, 65);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(101, 19);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(12, 40);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(53, 19);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            rdbResta.CheckedChanged += rdbResta_CheckedChanged;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(12, 15);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(55, 19);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            rdbSuma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(VariableB);
            Controls.Add(lblVariableA);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Name = "frmCalculadora";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Label lblVariableA;
        private Label VariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}
