using System.Collections.Generic;


namespace OrderAndDeliverySystem.Models.People
{
    public class StoreOperationsStaff : Staff
    {
        public StoreOperationsStaff(int personID, string name, string email, string password,
                                    int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "StoreOperations", isAvailable)
        {
        }
    }
}