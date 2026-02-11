namespace Calculadora
{
    partial class frmMenus
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSimpleToolStripMenuItem = new ToolStripMenuItem();
            ordenamientosToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            temporizadoresToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSimpleToolStripMenuItem, ordenamientosToolStripMenuItem, menuToolStripMenuItem, temporizadoresToolStripMenuItem, editorDeTextoToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSimpleToolStripMenuItem
            // 
            calculadoraSimpleToolStripMenuItem.Name = "calculadoraSimpleToolStripMenuItem";
            calculadoraSimpleToolStripMenuItem.Size = new Size(180, 22);
            calculadoraSimpleToolStripMenuItem.Text = "Calculadora simple";
            calculadoraSimpleToolStripMenuItem.Click += calculadoraSimpleToolStripMenuItem_Click;
            // 
            // ordenamientosToolStripMenuItem
            // 
            ordenamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            ordenamientosToolStripMenuItem.Size = new Size(180, 22);
            ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            ordenamientosToolStripMenuItem.Click += ordenamientosToolStripMenuItem_Click;
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(115, 22);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(180, 22);
            menuToolStripMenuItem.Text = "Registros";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // temporizadoresToolStripMenuItem
            // 
            temporizadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relojToolStripMenuItem });
            temporizadoresToolStripMenuItem.Name = "temporizadoresToolStripMenuItem";
            temporizadoresToolStripMenuItem.Size = new Size(180, 22);
            temporizadoresToolStripMenuItem.Text = "Temporizadores";
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(100, 22);
            relojToolStripMenuItem.Text = "Reloj";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(180, 22);
            editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            editorDeTextoToolStripMenuItem.Click += editorDeTextoToolStripMenuItem_Click;
            // 
            // frmMenus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenus";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraSimpleToolStripMenuItem;
        private ToolStripMenuItem ordenamientosToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem temporizadoresToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
    }
}