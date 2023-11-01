namespace PE_PRN211_FA23_Trial_SE173445
{
    partial class frmLogin
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
            labelUsername = new Label();
            labelPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtClose = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(19, 35);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            labelUsername.Click += labelUsername_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(19, 70);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 63);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 113);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtClose
            // 
            txtClose.Location = new Point(314, 113);
            txtClose.Name = "txtClose";
            txtClose.Size = new Size(94, 29);
            txtClose.TabIndex = 3;
            txtClose.Text = "Close";
            txtClose.UseVisualStyleBackColor = true;
            txtClose.Click += txtClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelUsername);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtClose);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 163);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 192);
            Controls.Add(groupBox1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button txtClose;
        private GroupBox groupBox1;
    }
}