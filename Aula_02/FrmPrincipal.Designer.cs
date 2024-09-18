namespace Aula_02
{
    partial class FrmPrincipal
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
            TsCadastro = new ToolStripMenuItem();
            TsGenero = new ToolStripMenuItem();
            TsAutor = new ToolStripMenuItem();
            TsSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsCadastro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsCadastro
            // 
            TsCadastro.DropDownItems.AddRange(new ToolStripItem[] { TsGenero, TsAutor, TsSair });
            TsCadastro.Name = "TsCadastro";
            TsCadastro.Size = new Size(66, 20);
            TsCadastro.Text = "&Cadastro";
            TsCadastro.Click += cadastroToolStripMenuItem_Click;
            // 
            // TsGenero
            // 
            TsGenero.Name = "TsGenero";
            TsGenero.Size = new Size(180, 22);
            TsGenero.Text = "&Gênero";
            TsGenero.Click += TsGenero_Click;
            // 
            // TsAutor
            // 
            TsAutor.Name = "TsAutor";
            TsAutor.Size = new Size(180, 22);
            TsAutor.Text = "&Autor";
            TsAutor.Click += TsAutor_Click;
            // 
            // TsSair
            // 
            TsSair.Name = "TsSair";
            TsSair.Size = new Size(180, 22);
            TsSair.Text = "&Sair";
            TsSair.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gêneroToolStripMenuItem;
        public ToolStripMenuItem TsSair;
        public ToolStripMenuItem TsCadastro;
        public ToolStripMenuItem TsGenero;
        public ToolStripMenuItem TsAutor;
    }
}