using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace OrderAndDeliverySystem.Data
{
    public static class DatabaseInitializer
    {
        // dbFolder and dbFile determines where the database file is stored
        private static readonly string dbFolder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string dbFile = Path.Combine(dbFolder, "internal-management.db");

        // Allow other classes to connect to database   
        public static string connectionSource => $"Data Source={dbFile}";

        // This runs once when the app starts
        public static void Initialize()
        {
            // Create the Data folder if it doesn't exist yet
            Directory.CreateDirectory(dbFolder);

            // Open a connection to the database file
            using SqliteConnection connection = new(connectionSource);
            connection.Open();

            CreateTables(connection); //Create the tables (only if they don't exist yet)
            DemoData(connection); //Dummy data
        }

        // Creates the 4 tables Staff, Orders, Tasks and Notifications
        private static void CreateTables(SqliteConnection connection)
        {
            string sql = """
                CREATE TABLE IF NOT EXISTS Staff (
                    StaffId   INTEGER PRIMARY KEY,
                    PersonId  INTEGER NOT NULL,
                    Name      TEXT    NOT NULL,
                    Email     TEXT    NOT NULL UNIQUE,
                    Password  TEXT    NOT NULL,
                    Role      TEXT    NOT NULL,
                    IsAvailable INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Orders (
                    OrderId            INTEGER PRIMARY KEY,
                    CustomerName       TEXT NOT NULL,
                    DestinationAddress TEXT NOT NULL,
                    Status             TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Tasks (
                    TaskId            INTEGER PRIMARY KEY,
                    OrderId           INTEGER NOT NULL,
                    AssignedStaffId   INTEGER NOT NULL,
                    AssignedByStaffId INTEGER NOT NULL,
                    Description       TEXT    NOT NULL,
                    Status            TEXT    NOT NULL,
                    DeadlineUtc       TEXT    NOT NULL,
                    CreatedUtc        TEXT    NOT NULL,
                    FOREIGN KEY (OrderId)           REFERENCES Orders(OrderId),
                    FOREIGN KEY (AssignedStaffId)   REFERENCES Staff(StaffId),
                    FOREIGN KEY (AssignedByStaffId) REFERENCES Staff(StaffId)
                );

                CREATE TABLE IF NOT EXISTS Notifications (
                    NotificationId INTEGER PRIMARY KEY,
                    StaffId        INTEGER NOT NULL,
                    Title          TEXT    NOT NULL,
                    Message        TEXT    NOT NULL,
                    Type           TEXT    NOT NULL,
                    IsRead         INTEGER NOT NULL,
                    CreatedUtc     TEXT    NOT NULL,
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
                INSERT INTO Staff (StaffId, PersonId, Name, Email, Password, Role, IsAvailable) VALUES
                (1, 101, 'Sarah (Shift Manager)',  'shift.manager', '123', 'ShiftManager',    1),
                (2, 102, 'Oscar (Store Ops)',      'store.ops',     '123', 'StoreOperations', 1),
                (3, 103, 'Mia (Store Manager)',    'store.manager', '123', 'StoreManager',    1);

                INSERT INTO Orders (OrderId, CustomerName, DestinationAddress, Status) VALUES
                (1001, 'Alex Chen',    '12 Queen Street, Auckland',  'Pending Picking'),
                (1002, 'Taylor Singh', '48 Dominion Road, Auckland', 'Packing'),
                (1003, 'Jordan Lee',   '7 Ponsonby Road, Auckland',  'Awaiting Stock Check');

                INSERT INTO Tasks (TaskId, OrderId, AssignedStaffId, AssignedByStaffId, Description, Status, DeadlineUtc, CreatedUtc) VALUES
                (2001, 1001, 2, 1, 'Pick and pack order #1001',          'Assigned',   '2026-05-19T08:30:00Z', '2026-05-18T20:00:00Z'),
                (2002, 1003, 2, 1, 'Check unavailable item for #1003',   'InProgress', '2026-05-19T09:15:00Z', '2026-05-18T20:05:00Z');

                INSERT INTO Notifications (NotificationId, StaffId, Title, Message, Type, IsRead, CreatedUtc) VALUES
                (3001, 1, 'Task status update', 'Order #1003 has started processing.', 'Task', 0, '2026-05-18T20:10:00Z'),
                (3002, 2, 'New task assigned',  'You have been assigned order #1001.', 'Task', 0, '2026-05-18T20:00:00Z');
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