using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Store;

namespace OrderAndDeliverySystem.Forms
{
    public partial class StoreOperationStaffForm : Form
    {
        private TaskService taskService;
        private NotificationService notificationService;
        private StoreOperationStaff storeOpsStaff;

        public StoreOperationStaffForm(Staff staff)
        {
            InitializeComponent();
            taskService = new TaskService();
            notificationService = new NotificationService();
            storeOpsStaff = (StoreOperationStaff)staff;
            LoadTasks();
            LoadNotifications();
        }

        // Load tasks assigned to this staff member
        private void LoadTasks()
        {
            List<StaffTask> tasks = taskService.GetTasksByStaffId(storeOpsStaff.StaffID);
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }

        // Load notifications for this staff member
        private void LoadNotifications()
        {
            var notifications = notificationService.GetNotifications(storeOpsStaff.StaffID);
            lstNotifications.Items.Clear();
            foreach (var n in notifications)
            {
                lstNotifications.Items.Add($"[{n.SentAt:HH:mm}] {n.Message}");
            }
        }

        // Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
            LoadNotifications();
        }

        // Mark task as In Progress
        private void btnInProgress_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task.", "Error");
                return;
            }

            StaffTask selectedTask = (StaffTask)dgvTasks.SelectedRows[0].DataBoundItem;
            taskService.UpdateTaskStatus(selectedTask.TaskID, "InProgress");
            MessageBox.Show("Task marked as In Progress.", "Success");
            LoadTasks();
        }

        // Mark task as Completed
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task.", "Error");
                return;
            }

            StaffTask selectedTask = (StaffTask)dgvTasks.SelectedRows[0].DataBoundItem;
            taskService.UpdateTaskStatus(selectedTask.TaskID, "Completed");
            MessageBox.Show("Task marked as Completed.", "Success");
            LoadTasks();
        }
    }
}