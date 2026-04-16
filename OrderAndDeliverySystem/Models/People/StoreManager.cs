using OrderAndDeliverySystem.Models.Store;
using StoreEntity = OrderAndDeliverySystem.Models.Store.Stores;

namespace OrderAndDeliverySystem.Models.People
{
    public class StoreManager : Staff
    {
        private Stores store;

        public StoreManager(int personID, string name, string email, string password, string phoneNumber,
                            int staffID, string role, bool availability, Stores store)
            : base(personID, name, email, password, phoneNumber, staffID, role, availability)
        {
            this.store = store;
        }

        public Stores GetStore()
        {
            return store;
        }

        public void ViewOrderPerformance()
        {

        }

        public void ViewStockQuantities()
        {

        }

        public void ReviewCustomerFeedback()
        {

        }

        public void UpdateStoreInformation(Stores store)
        {

        }
    }
}