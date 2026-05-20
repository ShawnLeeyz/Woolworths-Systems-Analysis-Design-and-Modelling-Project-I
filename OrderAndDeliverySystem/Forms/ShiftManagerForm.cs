using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Store;

namespace OrderAndDeliverySystem.Forms
{
    public partial class ShiftManagerForm : Form
    {
        private TaskService taskService;
        private NotificationService notificationService;
        private ShiftManager shiftManager;

        public ShiftManagerForm(Staff staff)
        {
            InitializeComponent();
            taskService = new TaskService();
            notificationService = new NotificationService();
            shiftManager = (ShiftManager)staff;
            LoadTasks();
            LoadNotifications();
        }

        // Load all tasks into the DataGridView
        private void LoadTasks()
        {
            List<StaffTask> tasks = taskService.GetAllTasks();
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }

        // Load notifications into the ListBox
        private void LoadNotifications()
        {
            var notifications = notificationService.GetNotifications(shiftManager.StaffID);
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

        // Assign task button
        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            // TODO: open AssignTaskForm
            AssignTaskForm assignTaskForm = new AssignTaskForm(shiftManager);
            assignTaskForm.ShowDialog();
            LoadTasks();
        }

        // Reassign task button
        private void btnReassignTask_Click(object sender, EventArgs e)
        {
            // TODO: open ReassignTaskForm
            ReassignTaskForm reassignTaskForm = new ReassignTaskForm(shiftManager);
            reassignTaskForm.ShowDialog();
            LoadTasks();
        }
    }
}