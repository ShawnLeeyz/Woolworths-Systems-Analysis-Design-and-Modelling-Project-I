using Microsoft.Data.Sqlite;
using OrderAndDeliverySystem.Data;
using OrderAndDeliverySystem.Models.Store;

namespace OrderAndDeliverySystem.Data.Repositories
{
    // Repository class for tasks, which handles all database interactions related to tasks
    public class TaskRepository
    {
        private SqliteConnection connection;

        public TaskRepository()
        {
            connection = DatabaseManager.Instance().GetConnection(); // global variable for database connection
        }

        // This method retrieves all tasks from the database and returns them as a list of Task objects 
        public List<Task> GetAllTasks()
        {
            using SqliteCommand command = connection.CreateCommand();
            string sql = "SELECT * FROM Tasks";
            command.CommandText = sql;
            using SqliteDataReader reader = command.ExecuteReader(); // Execute the SQL command and get the result in a reader

            List<Task> tasks = new List<Task>();
            // Goes through each row in the result and add it into the list of tasks
            while (reader.Read())
            {
                int taskId = reader.GetInt32(0);  
                string description = reader.GetString(1); 
                DateTime deadline = DateTime.Parse(reader.GetString(2)); 
                string status = reader.GetString(3);
                DateTime createdAt = DateTime.Parse(reader.GetString(4));
                int assignedStaffId = reader.GetInt32(5);

                Task task = new Task(taskId, description, deadline, status, createdAt, null);
                tasks.Add(task);
            }
            return tasks;
        }

        // This method retrieves all task assigned to a specific staff 
        public List<Task> GetTasksByStaffId(int inputStaffId)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$staffId", inputStaffId);

            string sql = "SELECT * FROM Tasks WHERE AssignedStaffId = $staffId"; // SQL command to get tasks with specific staffId
            command.CommandText = sql;
            using SqliteDataReader reader = command.ExecuteReader();

            List<Task> tasks = new List<Task>();
            // Goes through each row in the result and add it into the list of tasks
            while (reader.Read())
            {
                int taskId = reader.GetInt32(0);  
                string description = reader.GetString(1); 
                DateTime deadline = DateTime.Parse(reader.GetString(2)); 
                string status = reader.GetString(3);
                DateTime createdAt = DateTime.Parse(reader.GetString(4));
                int assignedStaffId = reader.GetInt32(5);

                Task task = new Task(taskId, description, deadline, status, createdAt, null);
                tasks.Add(task);
            }
            return tasks;
        }

        // This method inserts new task into the database
        public void InsertTask(Task task)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$description",     task.Description);
            command.Parameters.AddWithValue("$deadlineAt",      task.Deadline.ToString("o"));
            command.Parameters.AddWithValue("$status",          task.Status);
            command.Parameters.AddWithValue("$createdAt",       task.CreatedAt.ToString("o"));
            command.Parameters.AddWithValue("$assignedStaffId", task.AssignedStaff.StaffID);

            string sql = """
                INSERT INTO Tasks (Description, 
                                DeadlineAt, 
                                Status, 
                                CreatedAt,
                                AssignedStaffId) 
                VALUES ($description, 
                        $deadlineAt, 
                        $status, 
                        $createdAt,
                        $assignedStaffId)
                """;

            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        // This method only update status of task, when the shift manager is monitoring the progress and want to update the status of the task
        public void UpdateTaskStatus(int taskId, string status)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$status", status);
            command.Parameters.AddWithValue("$taskId", taskId);
            command.CommandText = "UPDATE Tasks SET Status = $status WHERE TaskId = $taskId";
            command.ExecuteNonQuery();
        }

        // This method updates the staff assigned to the task, when the shift manager reassigns the task to a different staff member
        public void UpdateTaskStaff(int taskId, int newStaffId)
        {
            using SqliteCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("$staffId", newStaffId);
            command.Parameters.AddWithValue("$taskId",  taskId);
            command.CommandText = "UPDATE Tasks SET AssignedStaffId = $staffId WHERE TaskId = $taskId";
            command.ExecuteNonQuery();
        }
    }
}