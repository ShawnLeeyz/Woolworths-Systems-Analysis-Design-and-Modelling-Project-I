using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;
using OrderAndDeliverySystem.Models.SupplyChain;
using OrderAndDeliverySystem.Models.Reports;
using OrderAndDeliverySystem.Services;

namespace OrderAndDeliverySystem.Models.People
{
    public class ProcurementSpecialist : Staff
    {
        private List<int> assignedStoreLocations;

        public ProcurementSpecialist(int personID, string name, string email, string password, int staffID, bool isAvailable)
            : base(personID, name, email, password, staffID, "ProcurementSpecialist", isAvailable)
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
