using System.Runtime.CompilerServices;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Notifications;

namespace OrderAndDeliverySystem.Models.Store
{
    // Task class to represent a task that can be assigned to store operations staff
    public class StaffTask
    {
        private int taskID;
        private string description;
        private DateTime deadline;
        private string status;
        private DateTime createdAt;
        private StoreOperationStaff? assignedStaff;
        // This constructor is used when creating a new task
        public StaffTask(int taskID, string description, DateTime deadline)
        {
            this.taskID = taskID;
            this.description = description;
            this.deadline = deadline;
            this.status = "Pending";
            this.createdAt = DateTime.Now;
            this.assignedStaff = null;
        }

        // This constructor is used when retrieving tasks from the database, which already have all attributes including status and createdAt
        public StaffTask(int taskID, string description, DateTime deadline, string status, DateTime createdAt, StoreOperationStaff? assignedStaff)
        {
            this.taskID      = taskID;
            this.description = description;
            this.deadline    = deadline;
            this.status      = status;
            this.createdAt   = createdAt;
            this.assignedStaff = assignedStaff;
        }
        //Get and set methods for Task attributes
        public int TaskID
        {
            get { return taskID; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public StoreOperationStaff? AssignedStaff
        {
            get { return assignedStaff; }
            set { assignedStaff = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        // This method checks if the task is overdue and triggers a notification if it is
        public Notification TriggerNotification()
        {
            // If task is overdue, create an overdue notification
            if (IsOverdue())
            {
                return new Notification(
                    0,
                    "Task is overdue: " + description,
                    NotificationType.IN_APP,
                    assignedStaff.StaffID
                );
            }
            // Otherwise create a new task assigned notification
            else
            {
                return new Notification(
                    0,
                    "You have been assigned a new task: " + description,
                    NotificationType.IN_APP,
                    assignedStaff.StaffID
                );
            }
        }

        // Checks if task is overdue based on current date and deadline date
        public bool IsOverdue()
        {
            if(DateTime.Now > deadline && status != "Completed")
            {
                return true;
            }
            return false;
        }

    }
}
