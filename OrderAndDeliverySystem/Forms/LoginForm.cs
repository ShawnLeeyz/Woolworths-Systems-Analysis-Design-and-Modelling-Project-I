using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrderAndDeliverySystem
{
    public class LoginForm : Form
    {
        private readonly Dictionary<string, Func<Form>> demoUsers = new(StringComparer.OrdinalIgnoreCase)
        {
            ["shift.manager"] = () => new ShiftManagerForm(),
            ["store.ops"] = () => new StoreOperationsForm(),
            ["store.manager"] = () => new StoreManagerForm()
        };

        private Label labelTitle = null!;
        private Label labelEmail = null!;
        private TextBox textEmail = null!;
        private Label labelPassword = null!;
        private TextBox textPassword = null!;
        private Label labelHelp = null!;
        private Label labelError = null!;
        private Button buttonLogin = null!;
        private Button buttonExit = null!;

        public LoginForm()
        {
            Text = "Woolworths Internal System";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            Load += LoginForm_Load;
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 4;

            labelTitle = new Label
            {
                Text = "Woolworths Internal System",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Size = new Size(420, 40),
                Location = new Point(centerX - 210, centerY),
                TextAlign = ContentAlignment.MiddleCenter
            };

            labelEmail = new Label
            {
                Text = "Demo Email",
                Size = new Size(300, 20),
                Location = new Point(centerX - 150, centerY + 70)
            };

            textEmail = new TextBox
            {
                Size = new Size(300, 25),
                Location = new Point(centerX - 150, centerY + 90)
            };

            labelPassword = new Label
            {
                Text = "Password",
                Size = new Size(300, 20),
                Location = new Point(centerX - 150, centerY + 130)
            };

            textPassword = new TextBox
            {
                Size = new Size(300, 25),
                Location = new Point(centerX - 150, centerY + 150),
                PasswordChar = '*'
            };

            labelHelp = new Label
            {
                Text = "Demo users: shift.manager, store.ops, store.manager | password: 123",
                Size = new Size(520, 20),
                Location = new Point(centerX - 260, centerY + 190),
                TextAlign = ContentAlignment.MiddleCenter
            };

            labelError = new Label
            {
                ForeColor = Color.Red,
                Size = new Size(420, 20),
                Location = new Point(centerX - 210, centerY + 220),
                TextAlign = ContentAlignment.MiddleCenter
            };

            buttonLogin = new Button
            {
                Text = "Login",
                Size = new Size(145, 35),
                Location = new Point(centerX - 150, centerY + 260)
            };
            buttonLogin.Click += BtnLogin_Click;

            buttonExit = new Button
            {
                Text = "Exit",
                Size = new Size(145, 35),
                Location = new Point(centerX + 5, centerY + 260)
            };
            buttonExit.Click += (_, _) => Application.Exit();

            Controls.Add(labelTitle);
            Controls.Add(labelEmail);
            Controls.Add(textEmail);
            Controls.Add(labelPassword);
            Controls.Add(textPassword);
            Controls.Add(labelHelp);
            Controls.Add(labelError);
            Controls.Add(buttonLogin);
            Controls.Add(buttonExit);
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();

            if (password != "123" || !demoUsers.TryGetValue(email, out Func<Form>? formFactory))
            {
                labelError.Text = "Use a demo email and password 123.";
                return;
            }

            labelError.Text = string.Empty;
            Form dashboard = formFactory();
            dashboard.FormClosed += (_, _) => Show();
            dashboard.Show();
            Hide();
        }
    }
}
