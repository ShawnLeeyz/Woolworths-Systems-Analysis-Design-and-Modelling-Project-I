namespace OrderAndDeliverySystem.Models.Notifications
{
    public class LowStockNotification : Notification
    {
        private int productID;

        public LowStockNotification(int notificationID, string message, string type, int productID)
            : base(notificationID, message, type)
        {
            this.productID = productID;
        }

        public int ProductID
        {
            get { return productID; }
        }

    }
}
