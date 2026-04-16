using System;
using OrderAndDeliverySystem.Models.Store;
using StoreEntity = OrderAndDeliverySystem.Models.Store.Stores;

namespace OrderAndDeliverySystem.Models.Products
{
    public class Stock
    {
        private int stockID;
        private int quantity;
        private int minimumThreshold;
        private int maximumThreshold;
        private DateTime lastUpdated;
        private Product product;
        private StoreEntity store;

        public Stock() { }

        public int GetStockID()
        {
            return stockID;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetMinimumThreshold()
        {
            return minimumThreshold;
        }

        public void SetMinimumThreshold(int minimumThreshold)
        {
            this.minimumThreshold = minimumThreshold;
        }

        public int GetMaximumThreshold()
        {
            return maximumThreshold;
        }

        public void SetMaximumThreshold(int maximumThreshold)
        {
            this.maximumThreshold = maximumThreshold;
        }

        public DateTime GetLastUpdated()
        {
            return lastUpdated;
        }

        public Product GetProduct()
        {
            return product;
        }

        public StoreEntity GetStore()
        {
            return store;
        }

        public bool IsLowStock()
        {
            return quantity < minimumThreshold;
        }

        public void UpdateStock(int quantity)
        {
            this.quantity = quantity;
            this.lastUpdated = DateTime.UtcNow;
        }
    }
}
