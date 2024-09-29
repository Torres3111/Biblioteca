namespace AulaAEDB01.Windows
{
    partial class FrmEditora
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
            LblNomeE = new Label();
            LblCodigoE = new Label();
            TxtNomeE = new TextBox();
            TxtCodigoE = new TextBox();
            GrdItensE = new DataGridView();
            CodigoE = new DataGridViewTextBoxColumn();
            NomeE = new DataGridViewTextBoxColumn();
            BtnAlterarE = new DataGridViewButtonColumn();
            BtnExcluirE = new DataGridViewButtonColumn();
            BtnFecharE = new Button();
            BtnSalvarE = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItensE).BeginInit();
            SuspendLayout();
            // 
            // LblNomeE
            // 
            LblNomeE.AutoSize = true;
            LblNomeE.Location = new Point(155, 17);
            LblNomeE.Name = "LblNomeE";
            LblNomeE.Size = new Size(40, 15);
            LblNomeE.TabIndex = 13;
            LblNomeE.Text = "Nome";
            // 
            // LblCodigoE
            // 
            LblCodigoE.AutoSize = true;
            LblCodigoE.Location = new Point(32, 17);
            LblCodigoE.Name = "LblCodigoE";
            LblCodigoE.Size = new Size(46, 15);
            LblCodigoE.TabIndex = 12;
            LblCodigoE.Text = "Código";
            // 
            // TxtNomeE
            // 
            TxtNomeE.Location = new Point(155, 44);
            TxtNomeE.Margin = new Padding(3, 2, 3, 2);
            TxtNomeE.MaxLength = 100;
            TxtNomeE.Name = "TxtNomeE";
            TxtNomeE.Size = new Size(496, 23);
            TxtNomeE.TabIndex = 11;
            // 
            // TxtCodigoE
            // 
            TxtCodigoE.Enabled = false;
            TxtCodigoE.Location = new Point(32, 44);
            TxtCodigoE.Margin = new Padding(3, 2, 3, 2);
            TxtCodigoE.MaxLength = 4;
            TxtCodigoE.Name = "TxtCodigoE";
            TxtCodigoE.Size = new Size(110, 23);
            TxtCodigoE.TabIndex = 10;
            // 
            // GrdItensE
            // 
            GrdItensE.AllowUserToAddRows = false;
            GrdItensE.AllowUserToDeleteRows = false;
            GrdItensE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensE.Columns.AddRange(new DataGridViewColumn[] { CodigoE, NomeE, BtnAlterarE, BtnExcluirE });
            GrdItensE.Location = new Point(3, 121);
            GrdItensE.Margin = new Padding(3, 2, 3, 2);
            GrdItensE.Name = "GrdItensE";
            GrdItensE.RowHeadersWidth = 51;
            GrdItensE.Size = new Size(695, 200);
            GrdItensE.TabIndex = 9;
            GrdItensE.CellContentClick += GrdItensE_CellClick;
            // 
            // CodigoE
            // 
            CodigoE.DataPropertyName = "CodigoE";
            CodigoE.HeaderText = "Codigo";
            CodigoE.MinimumWidth = 6;
            CodigoE.Name = "CodigoE";
            CodigoE.Width = 125;
            // 
            // NomeE
            // 
            NomeE.DataPropertyName = "NomeE";
            NomeE.HeaderText = "Nome";
            NomeE.MinimumWidth = 6;
            NomeE.Name = "NomeE";
            NomeE.Width = 125;
            // 
            // BtnAlterarE
            // 
            BtnAlterarE.DataPropertyName = "BtnAlterarE";
            BtnAlterarE.HeaderText = "Alterar";
            BtnAlterarE.MinimumWidth = 6;
            BtnAlterarE.Name = "BtnAlterarE";
            BtnAlterarE.Width = 125;
            // 
            // BtnExcluirE
            // 
            BtnExcluirE.DataPropertyName = "BtnExcluirE";
            BtnExcluirE.HeaderText = "Excluir";
            BtnExcluirE.MinimumWidth = 6;
            BtnExcluirE.Name = "BtnExcluirE";
            BtnExcluirE.Width = 125;
            // 
            // BtnFecharE
            // 
            BtnFecharE.Location = new Point(199, 82);
            BtnFecharE.Margin = new Padding(3, 2, 3, 2);
            BtnFecharE.Name = "BtnFecharE";
            BtnFecharE.Size = new Size(136, 26);
            BtnFecharE.TabIndex = 8;
            BtnFecharE.Text = "&Fechar";
            BtnFecharE.UseVisualStyleBackColor = true;
            BtnFecharE.Click += BtnFecharE_Click;
            // 
            // BtnSalvarE
            // 
            BtnSalvarE.Location = new Point(32, 82);
            BtnSalvarE.Margin = new Padding(3, 2, 3, 2);
            BtnSalvarE.Name = "BtnSalvarE";
            BtnSalvarE.Size = new Size(136, 26);
            BtnSalvarE.TabIndex = 7;
            BtnSalvarE.Text = "&Salvar";
            BtnSalvarE.UseVisualStyleBackColor = true;
            BtnSalvarE.Click += BtnSalvarE_Click;
            // 
            // FrmEditora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(LblNomeE);
            Controls.Add(LblCodigoE);
            Controls.Add(TxtNomeE);
            Controls.Add(TxtCodigoE);
            Controls.Add(GrdItensE);
            Controls.Add(BtnFecharE);
            Controls.Add(BtnSalvarE);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEditora";
            Text = "FrmEditora";
            Activated += FrmEditora_Activated;
            FormClosed += FrmEditora_FormClosed;
            Load += FrmEditora_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeE;
        private Label LblCodigoE;
        private TextBox TxtNomeE;
        private TextBox TxtCodigoE;
        private DataGridView GrdItensE;
        private DataGridViewTextBoxColumn CodigoE;
        private DataGridViewTextBoxColumn NomeE;
        private DataGridViewButtonColumn BtnAlterarE;
        private DataGridViewButtonColumn BtnExcluirE;
        private Button BtnFecharE;
        private Button BtnSalvarE;
    }
}