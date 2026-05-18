using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Store;
using StoreTask = OrderAndDeliverySystem.Models.Store.Task;

namespace OrderAndDeliverySystem.Models.People
{
    public class ShiftManager : Staff
    {
        public ShiftManager(int personID, string name, string email, string password,
                            int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "ShiftManager", isAvailable)
        {
        }
    }
}
