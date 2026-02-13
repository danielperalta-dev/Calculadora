namespace Calculadora.Formularios
{
    partial class frmEditor
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
            statusStrip1 = new StatusStrip();
            tssEstatus = new ToolStripStatusLabel();
            rtbEditor = new RichTextBox();
            mnsEditor = new MenuStrip();
            editorToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            opfEditor = new OpenFileDialog();
            svfEditor = new SaveFileDialog();
            ftdEditor = new FontDialog();
            cvdEditor = new ColorDialog();
            statusStrip1.SuspendLayout();
            mnsEditor.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssEstatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssEstatus
            // 
            tssEstatus.Name = "tssEstatus";
            tssEstatus.Size = new Size(58, 17);
            tssEstatus.Text = "tssEstatus";
            tssEstatus.Click += tssEstatus_Click;
            // 
            // rtbEditor
            // 
            rtbEditor.Location = new Point(0, 27);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 383);
            rtbEditor.TabIndex = 1;
            rtbEditor.Text = "";
            rtbEditor.TextChanged += rtbEditor_TextChanged;
            // 
            // mnsEditor
            // 
            mnsEditor.Items.AddRange(new ToolStripItem[] { editorToolStripMenuItem, editarToolStripMenuItem });
            mnsEditor.Location = new Point(0, 0);
            mnsEditor.Name = "mnsEditor";
            mnsEditor.Size = new Size(800, 24);
            mnsEditor.TabIndex = 2;
            mnsEditor.Text = "menuStrip1";
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(60, 20);
            editorToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(150, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(150, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(150, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(150, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(150, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Fuente";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // opfEditor
            // 
            opfEditor.Filter = "\"Archivos de Texto\"|*.txt";
            // 
            // svfEditor
            // 
            svfEditor.Filter = "\"Archivos de Texto\"|*.txt";
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbEditor);
            Controls.Add(statusStrip1);
            Controls.Add(mnsEditor);
            MainMenuStrip = mnsEditor;
            Name = "frmEditor";
            Text = "Editor de texto";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mnsEditor.ResumeLayout(false);
            mnsEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private RichTextBox rtbEditor;
        private MenuStrip mnsEditor;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog opfEditor;
        private SaveFileDialog svfEditor;
        private ToolStripStatusLabel tssEstatus;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog ftdEditor;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog cvdEditor;
    }
}