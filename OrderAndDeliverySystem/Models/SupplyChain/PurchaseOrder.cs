using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.SupplyChain
{
    public class PurchaseOrder
    {
        private int purchaseOrderID;
        private DateTime dateCreated;
        private string status;
        private List<Product>items;
        private float totalCost;
        private Supplier supplier;
        private DateTime expectedDelivery;

        public PurchaseOrder() { }

        public int PurchaseOrderID
        {
            get { return purchaseOrderID; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void submit()
        {
            
        }

    }
}
