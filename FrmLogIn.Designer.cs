namespace AulaAEDB01.Windows
{
    partial class FrmLogIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtUser = new TextBox();
            TxtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 177);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(38, 106);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(195, 23);
            TxtUser.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(38, 197);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(195, 23);
            TxtSenha.TabIndex = 4;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(84, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log-In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 319);
            Controls.Add(btnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
            Load += FrmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtUser;
        private TextBox TxtSenha;
        private Button btnLogin;
    }
}