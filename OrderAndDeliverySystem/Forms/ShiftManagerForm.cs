using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderAndDeliverySystem
{
    public class ShiftManagerForm : Form
    {
        public ShiftManagerForm()
        {
            Text = "Shift Manager Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            Load += ShiftManagerForm_Load;
        }

        private void ShiftManagerForm_Load(object? sender, EventArgs e)
        {
            Controls.Clear();

            Label title = new Label
            {
                Text = "Shift Manager Dashboard",
                Font = new Font("Arial", 28, FontStyle.Bold),
                Size = new Size(520, 45),
                Location = new Point(60, 40)
            };

            Label summary = new Label
            {
                Text = "Step 1 complete: this screen will manage task assignment, overdue tasks, and notifications.",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(900, 30),
                Location = new Point(60, 100)
            };

            ListBox taskPreview = new ListBox
            {
                Size = new Size(500, 220),
                Location = new Point(60, 160)
            };
            taskPreview.Items.Add("Demo task queue");
            taskPreview.Items.Add("Order #1001 - Assign picker");
            taskPreview.Items.Add("Order #1002 - Reassign overdue pick-and-pack");

            Button logoutButton = new Button
            {
                Text = "Logout",
                Size = new Size(140, 36),
                Location = new Point(60, 410)
            };
            logoutButton.Click += (_, _) => Close();

            Controls.Add(title);
            Controls.Add(summary);
            Controls.Add(taskPreview);
            Controls.Add(logoutButton);
        }
    }
}
