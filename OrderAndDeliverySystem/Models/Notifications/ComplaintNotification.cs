namespace OrderAndDeliverySystem.Models.Notifications
{
    public class ComplaintNotification : Notification
    {
        private int complaintID;

        public ComplaintNotification(int notificationID, string message, string type, int complaintID)
            : base(notificationID, message, type)
        {
            this.complaintID = complaintID;
        }
        public int ComplaintID
        {
            get { return complaintID; }
        }

    }
}
