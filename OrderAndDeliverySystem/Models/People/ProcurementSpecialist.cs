using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;
using OrderAndDeliverySystem.Models.SupplyChain;
using OrderAndDeliverySystem.Models.Reports;

namespace OrderAndDeliverySystem.Models.People
{
    public class ProcurementSpecialist : Staff
    {
        private List<int> assignedStoreLocations;

        public ProcurementSpecialist() : base(0, string.Empty, string.Empty, string.Empty, string.Empty, 0, string.Empty, true)
        {
            assignedStoreLocations = new List<int>();
        }

        public List<int> GetAssignedStoreLocations()
        {
            return assignedStoreLocations;
        }

        public void CreatePurchaseOrder(Supplier supplier, Product product, int quantity)
        {

        }

        public ProcurementReport GenerateReport()
        {
            return null;
        }

        public void ViewProductInventory()
        {

        }

        public void ViewSupplierData()
        {

        }
    }
}
