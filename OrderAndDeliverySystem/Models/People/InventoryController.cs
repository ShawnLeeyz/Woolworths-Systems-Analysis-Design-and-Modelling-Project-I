using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;
using OrderAndDeliverySystem.Models.SupplyChain;
using OrderAndDeliverySystem.Models.Reports;

namespace OrderAndDeliverySystem.Models.People
{
    public class InventoryController
    {
        private List<int> assignedStoreLocations;

        public InventoryController()
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
            return new InventoryReport();
        }
    }
}

