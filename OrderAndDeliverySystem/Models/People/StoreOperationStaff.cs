using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Orders;

namespace OrderAndDeliverySystem.Models.People
{
    public class StoreOperationStaff : Staff
    {
        private List<Order> assignedOrders;

        public StoreOperationStaff(int personID, string name, string email, string password, string phoneNumber,
                                   int staffID, string role, bool availability)
            : base(personID, name, email, password, phoneNumber, staffID, role, availability)
        {
            assignedOrders = new List<Order>();
        }

        public List<Order> AssignedOrders
        {
            get { return assignedOrders; }
        }

        public void updateOrderStatus(Order order, string status)
        {
            
        }
    }
}