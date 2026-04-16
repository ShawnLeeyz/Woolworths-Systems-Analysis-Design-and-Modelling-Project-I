namespace OrderAndDeliverySystem.Models.Notifications
{
    public class TaskNotification : Notification
    {
        private int taskID;


        public TaskNotification(int notificationID, string message, string type, int taskID) 
        : base(notificationID, message, type)
        {
            this.taskID = taskID;
        }

        public int TaskID
        {
            get { return taskID; }
        }

    }
}
