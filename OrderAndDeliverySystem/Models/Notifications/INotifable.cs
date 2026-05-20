namespace OrderAndDeliverySystem.Models.Notifications
{   
    // Interface for any class that can receive notifications
    public interface INotifable
    {        void triggerNotification(Notification notification);
    }
}