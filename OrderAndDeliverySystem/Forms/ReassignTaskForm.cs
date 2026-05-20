using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Store;
using OrderAndDeliverySystem.Data.Repositories;

namespace OrderAndDeliverySystem.Forms
{
    public partial class ReassignTaskForm : Form
    {
        private TaskService taskService;
        private StaffRepository staffRepository;
        private ShiftManager shiftManager;

        public ReassignTaskForm(ShiftManager shiftManager)
        {
            InitializeComponent();
            this.shiftManager = shiftManager;
            taskService = new TaskService();
            staffRepository = new StaffRepository();
            LoadTaskDropdown();
            LoadStaffDropdown();
        }

        // Load all tasks into dropdown
        private void LoadTaskDropdown()
        {
            List<StaffTask> allTasks = taskService.GetAllTasks();
            foreach (StaffTask task in allTasks)
            {
                cmbTask.Items.Add(task);
            }
            cmbTask.DisplayMember = "Description"; // show description in dropdown
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

        // Reassign button
        private void btnReassign_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (cmbTask.SelectedItem == null)
            {
                MessageBox.Show("Please select a task.", "Error");
                return;
            }
            if (cmbStaff.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member.", "Error");
                return;
            }

            // Get selected task and staff
            StaffTask selectedTask = (StaffTask)cmbTask.SelectedItem;
            StoreOperationStaff newStaff = (StoreOperationStaff)cmbStaff.SelectedItem;

            // Reassign the task
            taskService.ReassignTask(selectedTask.TaskID, newStaff);

            MessageBox.Show("Task reassigned successfully!", "Success");
            this.Close();
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}