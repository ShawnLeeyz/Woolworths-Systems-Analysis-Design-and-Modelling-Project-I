using OrderAndDeliverySystem.Data.Repositories;
using OrderAndDeliverySystem.Models.Notifications;

namespace OrderAndDeliverySystem.Services
{
    // This class is the mediator between the UI and the repository (accessing database), containing the business logic for notifications
    public class NotificationService
    {
        private NotificationRepository notificationRepository;

        public NotificationService()
        {
            // initialise repository to access database
            notificationRepository = new NotificationRepository();
        }

        // Get all notifications for a staff member
        public List<Notification> GetNotifications(int staffId)
        {
            return notificationRepository.GetNotificationsByStaffId(staffId);
        }

        // Create a new notification and save it to the database
        public void CreateNotification(string message, NotificationType type, int staffId)
        {
            Notification notification = new Notification(0, message, type, staffId);
            notificationRepository.InsertNotification(notification);
        }
    }
}