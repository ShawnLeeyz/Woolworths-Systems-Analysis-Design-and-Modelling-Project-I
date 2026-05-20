using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Forms
{
    public partial class LoginForm : Form
    {
        private AuthService authService;

        public LoginForm()
        {
            InitializeComponent();
            authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check fields are not empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password.", "Error");
                return;
            }

            // Try to login
            Staff staff = authService.Login(email, password);

            // Wrong credentials
            if (staff == null)
            {
                MessageBox.Show("Invalid email or password.", "Error");
                return;
            }

            // Route to correct dashboard
            if (staff.Role == "ShiftManager")
            {
                ShiftManagerForm form = new ShiftManagerForm(staff);
                form.Show();
                this.Hide();
            }
            else if (staff.Role == "StoreOperations")
            {
                StoreOperationStaffForm form = new StoreOperationStaffForm(staff);
                form.Show();
                this.Hide();
            }

            else if(staff.Role == "ProcurementSpecialist")
            {
                ProcurementSpecialistForm form = new ProcurementSpecialistForm(staff);
                form.Show();
                this.Hide();
            }
            else if (staff.Role == "InventoryController")
            {
                InventoryControllerForm form = new InventoryControllerForm(staff);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Role not supported yet.", "Info");
            }
        }
    }
}
