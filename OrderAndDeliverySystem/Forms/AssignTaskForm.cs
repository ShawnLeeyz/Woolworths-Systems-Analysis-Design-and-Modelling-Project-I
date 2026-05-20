using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Store;
using OrderAndDeliverySystem.Data.Repositories;

namespace OrderAndDeliverySystem.Forms
{
    public partial class AssignTaskForm : Form
    {
        private TaskService taskService;
        private StaffRepository staffRepository;
        private ShiftManager shiftManager;

        public AssignTaskForm(ShiftManager shiftManager)
        {
            InitializeComponent();
            this.shiftManager = shiftManager;
            taskService = new TaskService();
            staffRepository = new StaffRepository();
            LoadStaffDropdown();
        }

        // Load store operations staff into dropdown
        private void LoadStaffDropdown()
        {
            List<Staff> allStaff = staffRepository.GetAllStaff();
            foreach (Staff staff in allStaff)
            {
                if (staff.Role == "StoreOperations")
                {
                    cmbStaff.Items.Add(staff);
                }
            }
            cmbStaff.DisplayMember = "Name"; // show name in dropdown
        }

        // Assign button
        private void btnAssign_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Error");
                return;
            }

            if (cmbStaff.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member.", "Error");
                return;
            }

            // Get selected staff
            StoreOperationStaff selectedStaff = (StoreOperationStaff)cmbStaff.SelectedItem;

            // Assign the task
            taskService.AssignTask(
                txtDescription.Text.Trim(),
                dtpDeadline.Value,
                selectedStaff
            );

            MessageBox.Show("Task assigned successfully!", "Success");
            this.Close();
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}