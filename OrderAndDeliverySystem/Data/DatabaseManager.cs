using Microsoft.Data.Sqlite;
using System.IO;
using OrderAndDeliverySystem.Data;

namespace OrderAndDeliverySystem.Data
{
    public class DatabaseManager
    {

        // dbFolder and dbFile determines where the database file is stored
        private static readonly string dbFolder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string dbFile = Path.Combine(dbFolder, "internal-management.db");

        // allow other classes to connect to database   
        public static string connectionSource => $"Data Source={dbFile}";
        private static DatabaseManager instance;
        private SqliteConnection connection;

        // constructor prevents any other class from initializing another instance of databaseManager
        private DatabaseManager()
        {
            // create Folder for database
            Directory.CreateDirectory(dbFolder);
            // create and open the connection
            connection = new SqliteConnection(connectionSource);
            connection.Open();
        }

        // method that make sure theres only one instance
        public static DatabaseManager Instance()
        {
            // only create a new databaseManager if it doesnt already exist
            if(instance == null)
            {
                instance = new DatabaseManager();
            }
            return instance;
        }

        // return connection
        public SqliteConnection GetConnection()
        {
            return connection;
        }
    }
}