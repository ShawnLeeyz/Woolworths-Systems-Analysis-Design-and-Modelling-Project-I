using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.SupplyChain;

namespace OrderAndDeliverySystem.Models.Reports
{
    // The ProcurementReport class has all the necessary properties for a procurement report
    public class ProcurementReport : Report
    {
        private string stockLevels;
        private string demandTrends;
        private string outstandingPOs;

        // Default constructor for the ProcurementReportCreator class, since in factory method,
        // the createReport method needs to have no parameters could its the base template method for initalizing the reports
        public ProcurementReport() : base(){}

        public ProcurementReport(int reportID, Staff generatedBy, string title, string reportData, string stockLevels, string demandTrends, string outstandingPOs)
            : base(reportID, generatedBy, title, reportData)
        {
            this.stockLevels = stockLevels;
            this.demandTrends = demandTrends;
            this.outstandingPOs = outstandingPOs;
        }

        public string StockLevels
        {
            get { return stockLevels; }
            set { stockLevels = value; }
        }   
        public string DemandTrends
        {
            get { return demandTrends; }
            set { demandTrends = value; }
        }

        public string OutstandingPOs
        {
            get { return outstandingPOs; }
            set { outstandingPOs = value; }
        }

        // The Generate method compiles the procurement report data into a formatted string
        public override string Generate()
        {
            return "Stock Levels: " + StockLevels + "\n" +
                   "Demand Trends: " + DemandTrends + "\n" +
                   "Outstanding POs: " + OutstandingPOs;
        }
    }
}
