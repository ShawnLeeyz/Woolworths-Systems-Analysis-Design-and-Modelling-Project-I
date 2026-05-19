using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Store;
using StoreTask = OrderAndDeliverySystem.Models.Store.Task;

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
        public void AssignTask(StoreOperationsStaff staff, Task task)
        {
            task.AssignTo(staff);
        }

        // Reassigns a task to a different staff member
        public void ReassignTask(Task task, StoreOperationsStaff staff)
        {
            task.AssignTo(staff);
        }

        // Returns list of tasks to monitor progress
        public void MonitorProgress()
        {
        }
    }
}
