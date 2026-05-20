namespace OrderAndDeliverySystem.Forms
{
    partial class LoginForm
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
            emailLabel = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            heading = new Label();
            passwordLabel = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F);
            emailLabel.Location = new Point(35, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 21);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 50F);
            heading.Location = new Point(12, 20);
            heading.Name = "heading";
            heading.Size = new Size(614, 89);
            heading.TabIndex = 4;
            heading.Text = "Management Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F);
            passwordLabel.Location = new Point(26, 217);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(79, 21);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GrayText;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(26, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(passwordLabel);
            Controls.Add(heading);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label heading;
        private Label passwordLabel;
        private Button btnLogin;
    }
}