using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.Reports
{
    public class InventoryReport : Report
    {
        private List<Product> rankedProducts;
        private string restockFrequency;
        private string currentStockSummary;
        private List<int> storeLocations;
        private string reportPeriod;

        public InventoryReport()
        {
            rankedProducts = new List<Product>();
            storeLocations = new List<int>();
        }

        public override void Generate()
        {
        }

        public List<Product> GetRankedProducts()
        {
            return rankedProducts;
        }

        public string GetCurrentStockSummary()
        {
            return currentStockSummary;
        }
    }
}
