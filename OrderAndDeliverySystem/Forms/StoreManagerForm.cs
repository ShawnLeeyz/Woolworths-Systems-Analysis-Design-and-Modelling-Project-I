using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderAndDeliverySystem
{
    public class StoreManagerForm : Form
    {
        private Label labelTitle;
        public StoreManagerForm()
        {
            this.Text = "Store Manager Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += StoreManagerForm_Load;
        }

        private void StoreManagerForm_Load(object sender, EventArgs e)
        {
            //Title
            Label labelTitle = new Label();
            labelTitle.Text = "DashBoard";
            labelTitle.Font = new Font("Arial", 40, FontStyle.Bold);
            labelTitle.Size = new Size(500, 50);
            labelTitle.Location = new Point(this.ClientSize.Width / 4 - 200, 40);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(labelTitle);
        }
    }
}