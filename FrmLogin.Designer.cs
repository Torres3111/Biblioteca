namespace AulaAEDB01.Windows
{
    partial class FrmLogin
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
            UserLogin = new TextBox();
            label3 = new Label();
            SenhaLogin = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 39);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE BIBLIOTECA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 138);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // UserLogin
            // 
            UserLogin.Location = new Point(54, 156);
            UserLogin.Name = "UserLogin";
            UserLogin.Size = new Size(245, 23);
            UserLogin.TabIndex = 2;
            UserLogin.TextChanged += UserLogin_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 221);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // SenhaLogin
            // 
            SenhaLogin.Location = new Point(54, 239);
            SenhaLogin.Name = "SenhaLogin";
            SenhaLogin.Size = new Size(245, 23);
            SenhaLogin.TabIndex = 4;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(126, 314);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(92, 36);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Log-in";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 390);
            Controls.Add(BtnLogin);
            Controls.Add(SenhaLogin);
            Controls.Add(label3);
            Controls.Add(UserLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Log-in";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserLogin;
        private Label label3;
        private TextBox SenhaLogin;
        private Button BtnLogin;
    }
}