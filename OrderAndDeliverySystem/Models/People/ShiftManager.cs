using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Store;

namespace OrderAndDeliverySystem.Models.People
{
    // Shift manager class, which inherits from the staff class. It contains the attributes and methods specific to shift managers
    public class ShiftManager : Staff
    {
        public ShiftManager(int personID, string name, string email, string password,
                            int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "ShiftManager", isAvailable)
        {
        }

        // Assigns a task to a store operations staff member
        public void AssignTask(StoreOperationStaff staff, StaffTask task)
        {
            task.AssignedStaff = staff;
            task.Status = "Assigned";
        }

        // Reassigns a task to a different staff member
        public void ReassignTask(StaffTask task, StoreOperationStaff staff)
        {
            task.AssignedStaff = staff;
            task.Status = "Reassigned";
        }

        // Returns list of tasks to monitor progress
        public List<StaffTask> MonitorProgress(List<StaffTask> tasks)
        {
            List<StaffTask> overdueTasks = new List<StaffTask>();

            for (int i = 0; i <= tasks.Count - 1; i++)
            {
                if (tasks[i].IsOverdue())
                {
                    overdueTasks.Add(tasks[i]);
                }
            }

            return overdueTasks;
        }
    }
}
