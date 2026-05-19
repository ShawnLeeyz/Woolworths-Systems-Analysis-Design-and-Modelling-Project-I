using Microsoft.Data.Sqlite;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Data;

namespace OrderAndDeliverySystem.Data.Repositories
{
    // Repository class for staff members, which handles all database interactions related to staff members
    public class StaffRepository
    {
        private SqliteConnection connection; // global variable for database connection

        public StaffRepository()
        {
            connection = DatabaseManager.Instance().GetConnection();
        }
        // This method retrieves a staff member from the database based on email and password
        public Staff GetStaff(string inputemail, string inputpassword)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$email", inputemail);
            command.Parameters.AddWithValue("$password", inputpassword);
            string sql = "SELECT * FROM Staff WHERE Email = $email AND Password = $password";
            command.CommandText = sql; 
            using SqliteDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null; // Return null if no staff member is found
            }

            // Get all the attributes of the staff member by columns
            int personId = reader.GetInt32(1);
            string name = reader.GetString(2);
            string email = reader.GetString(3);
            string password = reader.GetString(4);
            int staffId = reader.GetInt32(0);
            string role = reader.GetString(5);
            if(reader.GetInt32(6) == 1) // Since SQLite does not support boolean, it stores in int 0 (false) or 1 (true)
            {
                bool isAvailable = true;
            }
            else
            {
                bool isAvailable = false;
            }

            // Create and return the correct type of staff member 
            if(role == "ShiftManager")
            {
                return new ShiftManager(personId, name, email, password, staffId, isAvailable);
            }
            else if(role == "StoreOperationStaff")
            {
                return new StoreOperationsStaff(personId, name, email, password, staffId, isAvailable);
            }
            else
            {
                throw new Exception("Invalid role in database");
            }
        }
    }
}