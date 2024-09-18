namespace Aula_02
{
    partial class Autor
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
            IdAutor = new Label();
            NomeAutor = new Label();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            GrdAutor = new DataGridView();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdAutor).BeginInit();
            SuspendLayout();
            // 
            // IdAutor
            // 
            IdAutor.AutoSize = true;
            IdAutor.Location = new Point(12, 8);
            IdAutor.Name = "IdAutor";
            IdAutor.Size = new Size(18, 15);
            IdAutor.TabIndex = 0;
            IdAutor.Text = "ID";
            IdAutor.Click += label1_Click;
            // 
            // NomeAutor
            // 
            NomeAutor.AutoSize = true;
            NomeAutor.Location = new Point(108, 8);
            NomeAutor.Name = "NomeAutor";
            NomeAutor.Size = new Size(40, 15);
            NomeAutor.TabIndex = 1;
            NomeAutor.Text = "Nome";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(12, 26);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(53, 23);
            TxtId.TabIndex = 2;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(108, 26);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(335, 23);
            TxtNome.TabIndex = 3;
            // 
            // GrdAutor
            // 
            GrdAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdAutor.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Alterar, Excluir });
            GrdAutor.Location = new Point(12, 96);
            GrdAutor.Name = "GrdAutor";
            GrdAutor.Size = new Size(444, 342);
            GrdAutor.TabIndex = 4;
            GrdAutor.CellClick += GrdAutor_CellClick;
            GrdAutor.CellContentClick += GrdAutor_CellContentClick;
            // 
            // BtnSalvar
            // 
            BtnSalvar.AccessibleName = "BtSalvar";
            BtnSalvar.AllowDrop = true;
            BtnSalvar.Location = new Point(12, 55);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 35);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += button1_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.AccessibleName = "";
            BtnFechar.AllowDrop = true;
            BtnFechar.Location = new Point(126, 55);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 35);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "ID";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "NOME";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Alterar
            // 
            Alterar.DataPropertyName = "Alterar";
            Alterar.HeaderText = "Alterar";
            Alterar.Name = "Alterar";
            // 
            // Excluir
            // 
            Excluir.DataPropertyName = "Excluir";
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            // 
            // Autor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdAutor);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(NomeAutor);
            Controls.Add(IdAutor);
            Name = "Autor";
            Text = "Autor";
            Load += Autor_Load;
            ((System.ComponentModel.ISupportInitialize)GrdAutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdAutor;
        private Label NomeAutor;
        private DataGridView GrdAutor;
        private TextBox TxtId;
        private TextBox TxtNome;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;
    }
}