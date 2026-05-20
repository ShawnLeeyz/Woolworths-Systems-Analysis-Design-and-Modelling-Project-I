using OrderAndDeliverySystem.Data.Repositories;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Store;
using OrderAndDeliverySystem.Models.Notifications;

namespace OrderAndDeliverySystem.Services
{
    // This class is the mediator between the UI and the repository (accessing database), containing the business logic for tasks
    public class TaskService
    {
        private TaskRepository taskRepository;
        private NotificationRepository notificationRepository;

        public TaskService()
        {
            taskRepository = new TaskRepository();
            notificationRepository = new NotificationRepository();
        }

        // Get all tasks in the system  
        public List<StaffTask> GetAllTasks()
        {
            return taskRepository.GetAllTasks();
        }

        // Get all tasks that are related to a single Staff member
        public List<StaffTask> GetTasksByStaffId(int staffId)
        {
            return taskRepository.GetTasksByStaffId(staffId);
        }


        // Creates a new task and notifies the assigned staff member
        public void AssignTask(string description, DateTime deadline, StoreOperationStaff staff)
        {
            StaffTask task = new StaffTask(0, description, deadline, "Pending", DateTime.Now, staff);
            taskRepository.InsertTask(task); // Insert the newly created task to the database

            Notification notification = task.TriggerNotification();
            if (notification != null)
            {
                notificationRepository.InsertNotification(notification);
            }
        }

        // Update the status of a task, e.g. from "Pending" to "Completed"
        public void UpdateTaskStatus(int taskId, string status)
        {
            taskRepository.UpdateTaskStatus(taskId, status);
        }

        // Reassign a task to another staff member
        public void ReassignTask(int taskId, StoreOperationStaff newStaff)
        {
            List<StaffTask> allTasks = taskRepository.GetAllTasks(); //Gets all the task assign to a staff
            StaffTask task = null;

            foreach (StaffTask t in allTasks) // Goes through each task in the list and see if the taskId matches a task
            {
                if (t.TaskID == taskId)
                {
                    task = t;
                    break;
                }
            }

            if (task != null)
            {
                task.AssignedStaff = newStaff; // Update the assigned staff in the Task object
                taskRepository.UpdateTaskStaff(taskId, newStaff.StaffID); // Update the assigned staff in the database
                Notification notification = task.TriggerNotification();
                if (notification != null)
                    notificationRepository.InsertNotification(notification);
            }
        }

        // This method simply returns all the task that is overdue
        public List<StaffTask> MonitorProgress(ShiftManager shiftManager)
        {
            List<StaffTask> allTasks = taskRepository.GetAllTasks();
            return shiftManager.MonitorProgress(allTasks);
        }
    }
}
