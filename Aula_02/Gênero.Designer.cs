namespace Aula_02
{
    partial class Gênero
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
            Codigo = new Label();
            Nome_Genero = new Label();
            TxtCodigo = new TextBox();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            GrdItens = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            ALTERAR = new DataGridViewButtonColumn();
            EXCLUIR = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Location = new Point(27, 30);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(46, 15);
            Codigo.TabIndex = 0;
            Codigo.Text = "Codigo";
            // 
            // Nome_Genero
            // 
            Nome_Genero.AutoSize = true;
            Nome_Genero.Location = new Point(106, 30);
            Nome_Genero.Name = "Nome_Genero";
            Nome_Genero.Size = new Size(40, 15);
            Nome_Genero.TabIndex = 1;
            Nome_Genero.Text = "Nome";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(31, 56);
            TxtCodigo.MaxLength = 20;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(53, 23);
            TxtCodigo.TabIndex = 2;
            TxtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 56);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(398, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(27, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 4;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += TxtCodigo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 95);
            button2.Name = "button2";
            button2.Size = new Size(71, 28);
            button2.TabIndex = 5;
            button2.Text = "FECHAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, ALTERAR, EXCLUIR });
            GrdItens.Location = new Point(27, 139);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(518, 320);
            GrdItens.TabIndex = 7;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "CODIGO";
            ID.HeaderText = "CODIGO";
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "NOME";
            Nome.HeaderText = "NOME";
            Nome.Name = "Nome";
            // 
            // ALTERAR
            // 
            ALTERAR.DataPropertyName = "ALTERAR";
            ALTERAR.HeaderText = "ALTERAR";
            ALTERAR.Name = "ALTERAR";
            // 
            // EXCLUIR
            // 
            EXCLUIR.DataPropertyName = "EXCLUIR";
            EXCLUIR.HeaderText = "EXCLUIR";
            EXCLUIR.Name = "EXCLUIR";
            // 
            // Gênero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(GrdItens);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(Nome_Genero);
            Controls.Add(Codigo);
            Name = "Gênero";
            Text = "Gênero";
            Load += Gênero_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Codigo;
        private Label Nome_Genero;
        private TextBox TxtCodigo;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn ALTERAR;
        private DataGridViewButtonColumn EXCLUIR;
    }
}