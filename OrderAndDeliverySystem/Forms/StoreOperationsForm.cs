using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderAndDeliverySystem
{
    public class StoreOperationsForm : Form
    {
        public StoreOperationsForm()
        {
            Text = "Store Operations Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            Load += StoreOperationsForm_Load;
        }

        private void StoreOperationsForm_Load(object? sender, EventArgs e)
        {
            Controls.Clear();

            Label title = new Label
            {
                Text = "Store Operations Dashboard",
                Font = new Font("Arial", 28, FontStyle.Bold),
                Size = new Size(560, 45),
                Location = new Point(60, 40)
            };

            Label summary = new Label
            {
                Text = "Step 1 complete: this screen will show assigned tasks and order status updates.",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(860, 30),
                Location = new Point(60, 100)
            };

            ListBox assignedTasks = new ListBox
            {
                Size = new Size(500, 220),
                Location = new Point(60, 160)
            };
            assignedTasks.Items.Add("Assigned tasks preview");
            assignedTasks.Items.Add("Order #1001 - Pick and pack");
            assignedTasks.Items.Add("Order #1003 - Check unavailable item");

            Button logoutButton = new Button
            {
                Text = "Logout",
                Size = new Size(140, 36),
                Location = new Point(60, 410)
            };
            logoutButton.Click += (_, _) => Close();

            Controls.Add(title);
            Controls.Add(summary);
            Controls.Add(assignedTasks);
            Controls.Add(logoutButton);
        }
    }
}
