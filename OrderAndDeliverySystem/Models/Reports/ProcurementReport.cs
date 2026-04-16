using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.SupplyChain;

namespace OrderAndDeliverySystem.Models.Reports
{
    public class ProcurementReport : Report
    {
        private string stockLevels;
        private string demandTrends;
        private List<PurchaseOrder> outstandingPOs;

        public ProcurementReport() 
        {
            outstandingPOs = new List<PurchaseOrder>();
        }

        public ProcurementReport(DateTime utcNow) 
        {
            outstandingPOs = new List<PurchaseOrder>();
        }

        public override void Generate()
        {

        }

        public string GetDemandTrends()
        {
            return demandTrends;
        }

        public string GetStockLevels()
        {
            return stockLevels;
        }
    }
}
