using System.Collections.Generic;
using OrderAndDeliverySystem.Models.SupplyChain;
using OrderAndDeliverySystem.Models.Reports;
using OrderAndDeliverySystem.Services;

namespace OrderAndDeliverySystem.Models.People
{
    public class InventoryController : Staff
    {
        private List<int> assignedStoreLocations;

        public InventoryController(int personID, string name, string email, string password, int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "InventoryController", isAvailable)
        {
            assignedStoreLocations = new List<int>();
        }
        public List<int> GetAssignedStoreLocations()
        {
            return assignedStoreLocations;
        }

        public void ViewProductInventory()
        {

        }

        public void ConfirmIncomingStock(PurchaseOrder purchaseOrder)
        {

        }

        public InventoryReport GenerateReport()
        {
            return null;
        }
    }
}
