using System.Data;
using Microsoft.Data.Sqlite;
using OrderAndDeliverySystem.Data;
using OrderAndDeliverySystem.Models.Notifications;

namespace OrderAndDeliverySystem.Data.Repositories
{
    // Repository class for notifications, which handles all database interactions related to notifications
    public class NotificationRepository
    {
        private SqliteConnection connection;

        public NotificationRepository()
        {
            connection = DatabaseManager.Instance().GetConnection(); // global variable for database connection
        }

        // Get all notifications for a specific staff member
        public List<Notification> GetNotificationsByStaffId(int inputstaffId)
        {
            using SqliteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("$staffId", inputstaffId);
            string sql = "SELECT * FROM Notifications WHERE staffId = $staffId";

            command.CommandText = sql;
            using SqliteDataReader reader = command.ExecuteReader();

            List<Notification> notifications = new List<Notification>();
            while (reader.Read())
            {
                int notificationId = reader.GetInt32(0);
                string message = reader.GetString(1);
                // Since the type is stored as string in database, we need to parse it back to enum
                Enum.TryParse(reader.GetString(2), true, out NotificationType type);
                DateTime sendAt = DateTime.Parse(reader.GetString(3));
                int staffId = reader.GetInt32(4);

                Notification notification = new Notification(notificationId, message, type, sendAt, staffId);
                notifications.Add(notification);
            }
            return notifications;
        }

        // Save a new notification to the database
        public void InsertNotification(Notification notification)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$staffId", notification.StaffID);
            command.Parameters.AddWithValue("$message", notification.Message);
            command.Parameters.AddWithValue("$type", notification.Type.ToString());
            command.Parameters.AddWithValue("$sendAt", notification.SentAt.ToString("o"));

            string sql = "INSERT INTO Notifications (Message, Type, SendAt, StaffId) VALUES ($message, $type, $sendAt, $staffId)";
            command.CommandText = sql;

            command.ExecuteNonQuery();

        }
    }
}