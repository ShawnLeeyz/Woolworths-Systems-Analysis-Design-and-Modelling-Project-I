using OrderAndDeliverySystem.Models.Store;
using System.Collections.Generic;


namespace OrderAndDeliverySystem.Models.People
{
    // Store operations staff class has existing attributes from Person and Staff class but also has assignedTask attribute to track tasks
    public class StoreOperationStaff : Staff
    {
        List<StaffTask> assignedTasks;
        public StoreOperationStaff(int personID, string name, string email, string password,
                                    int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "StoreOperations", isAvailable)
        {
            assignedTasks = new List<StaffTask>();
        }

        // Update the status of an order
        public void UpdateOrderStatus(Order order, string status)
        {
            
        }

        // Get all assigned tasks for display for Store Operation Staff
        public List<StaffTask> GetAssignedTasks()
        {
            return assignedTasks;
        }
    }
}
