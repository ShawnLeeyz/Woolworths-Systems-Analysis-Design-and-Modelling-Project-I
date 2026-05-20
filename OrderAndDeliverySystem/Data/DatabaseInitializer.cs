using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace OrderAndDeliverySystem.Data
{
    public static class DatabaseInitializer
    {

        // This runs once when the app starts
        public static void Initialize()
        {
            SqliteConnection connection = DatabaseManager.Instance().GetConnection(); // Get the connection from the database manager
            CreateTables(connection); //Create the tables
            DemoData(connection); //Dummy data
        }

        // Creates the 4 tables Staff, Orders, Tasks and Notifications
        private static void CreateTables(SqliteConnection connection)
        {
            string sql = """
                CREATE TABLE IF NOT EXISTS Staff (
                    PersonId INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Role TEXT NOT NULL,
                    IsAvailable INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Tasks (
                    TaskId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Description TEXT NOT NULL,
                    DeadlineAt TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL,
                    AssignedStaffId INTEGER NOT NULL,
                    FOREIGN KEY (AssignedStaffId) REFERENCES Staff(StaffId)
                );

                CREATE TABLE IF NOT EXISTS Notifications (
                    NotificationId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Message TEXT NOT NULL,
                    Type TEXT NOT NULL,
                    SendAt TEXT NOT NULL,
                    StaffId INTEGER NOT NULL,
                    FOREIGN KEY (StaffId) REFERENCES Staff(StaffId)
                );
                """;

            // Send the SQL to database and run the sql command
            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        // Adds demo staff, orders, tasks, and notifications
        private static void DemoData(SqliteConnection connection)
        {
            // If Staff table already has rows, skip this — data already exists
            if (HasRows(connection, "Staff"))
            {
                return;
            }

            string sql = """
                INSERT INTO Staff (PersonId, Name, Email, Password, Role, IsAvailable) VALUES
                    (101, 'Staff1', 'shift.manager', '123', 'ShiftManager', 1),
                    (102, 'Staff2', 'store.ops', '123', 'StoreOperations', 1),
                    (103, 'Staff3', 'store.ops1', '123', 'StoreOperations', 1);

                INSERT INTO Tasks (TaskId, Description, DeadlineAt, Status, CreatedAt, AssignedStaffId) VALUES
                    (2001, 'Pick and pack order 1001', '2026-05-19T08:30:00Z', 'Assigned', '2026-05-18T20:00:00Z', 2),
                    (2002, 'Check unavailable item for 1003', '2026-05-19T09:15:00Z', 'InProgress', '2026-05-18T20:05:00Z', 2);
                    (2002, 'Check unavailable item for 1003', '2026-05-19T09:15:00Z', 'InProgress', '2026-05-18T20:05:00Z', 1);

                INSERT INTO Notifications (NotificationId, Message, Type, SendAt, StaffId) VALUES
                    (3001, 'Task status update: Order 1003 has started processing.', 'IN_APP', '2026-05-18T20:10:00Z', 1),
                    (3002, 'New task assigned: You have been assigned order 1001.',  'IN_APP', '2026-05-18T20:00:00Z', 2);
            """;

            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        // This method checks if the existing tables has any rows
        private static bool HasRows(SqliteConnection connection, string tableName)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {tableName} LIMIT 1;";
            
            using SqliteDataReader reader = command.ExecuteReader();
            
            // Returns true if there is one row
            return reader.Read();
        }
    }
}