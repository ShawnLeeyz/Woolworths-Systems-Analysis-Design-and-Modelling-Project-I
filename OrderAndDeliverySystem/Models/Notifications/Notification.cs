using System;

namespace OrderAndDeliverySystem.Models.Notifications
{
    // It is the base attributes that all notifications have
    public class Notification
    {
        private int notificationID;
        private string message;        
        private NotificationType type;
        private DateTime sentAt;

        private int staffID;

        public Notification(int notificationID, string message, NotificationType type, int staffID)
        {
            this.notificationID = notificationID;
            this.message = message;
            this.type = type;
            this.sentAt = DateTime.Now;
            this.staffID = staffID;
        }

        // This constructor is used when retriving all attributes which includes sentAt
        public Notification(int notificationID, string message, NotificationType type, DateTime sentAt, int staffID)
        {
            this.notificationID = notificationID;
            this.message = message;
            this.type = type;
            this.sentAt = sentAt;
            this.staffID = staffID;
        }

        public int NotificationID
        {
            get { return notificationID; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public NotificationType Type
        {
            get { return type; }
        }

        public DateTime SentAt
        {
            get { return sentAt; }
        }

        public int StaffID
        {
            get { return staffID; }
        }
    }
}
