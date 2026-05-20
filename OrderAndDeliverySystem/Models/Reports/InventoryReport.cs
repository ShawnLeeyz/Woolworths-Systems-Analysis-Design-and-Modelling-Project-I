using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.Reports
{
    // InventoryReport class inherits from Report and includes specific properties related to inventory management
    public class InventoryReport : Report
    {
        private string rankedProducts;
        private string restockFrequency;
        private string currentStockSummary;
        private string storeLocations;
        private string reportPeriod;


        // Default constructor for the InventoryReportCreator class, since in factory method,
        // the createReport method needs to have no parameters could its the base template method for initalizing the reports
        public InventoryReport() : base(){}

        public InventoryReport(int reportID, Staff generatedBy, string title, string rankedProducts, string restockFrequency, string currentStockSummary, string storeLocations, string reportPeriod)
        : base(reportID, generatedBy, title, string.Empty)
        {
            this.rankedProducts = rankedProducts;
            this.restockFrequency = restockFrequency;
            this.currentStockSummary = currentStockSummary;
            this.storeLocations = storeLocations;
            this.reportPeriod = reportPeriod;
        }

        public string RankedProducts
        {
            get { return rankedProducts; }
            set { rankedProducts = value; }
        }

        public string RestockFrequency
        {
            get { return restockFrequency; }
            set { restockFrequency = value; }
        }

        public string StoreLocations
        {
            get { return storeLocations; }
            set { storeLocations = value; }
        }

        public string ReportPeriod
        {
            get { return reportPeriod; }
            set { reportPeriod = value; }
        }

        public string CurrentStockSummary
        {
            get { return currentStockSummary; }
            set { currentStockSummary = value; }
        }

        // The Generate method compiles the inventory report data into a formatted string
        public override string Generate()
        {
            return "Ranked Products: " + RankedProducts + "\n" +
                   "Restock Frequency: " + RestockFrequency + "\n" +
                   "Current Stock Summary: " + CurrentStockSummary + "\n" +
                   "Store Locations: " + StoreLocations + "\n" +
                   "Report Period: " + ReportPeriod;
        }

    }
}
