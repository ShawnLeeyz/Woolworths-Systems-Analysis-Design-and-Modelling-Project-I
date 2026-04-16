using System;

namespace OrderAndDeliverySystem.Models.Notifications
{
    public abstract class Notification
    {
        private int notificationID;
        private string message;        
        private string type;
        private DateTime sentAt;

        public Notification(int notificationID, string message, string type)
        {
            this.notificationID = notificationID;
            this.message = message;
            this.type = type;
            this.sentAt = DateTime.Now;
        }

        public int NotificationID
        {
            get { return notificationID; }
        }

        public string Message
        {
            get { return message; }
        }

        public string Type
        {
            get { return type; }
        }

    }
}
