namespace OrderAndDeliverySystem.Models.Notifications
{
    public class DeliveryNotification : Notification
    {
        private int deliveryID;

        public DeliveryNotification(int notificationID, string message, string type, int deliveryID)
            : base(notificationID, message, type)
        {
            this.deliveryID = deliveryID;
        }
        public int DeliveryID
        {
            get { return deliveryID; }
        }

    }
}
