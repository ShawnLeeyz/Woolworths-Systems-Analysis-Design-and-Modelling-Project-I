using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Reports
{
    // This class is responsible for creating instances of InventoryReport
    public class InventoryReportCreator : ReportCreator
    {
        public override Report CreateReport()
        {
            return new InventoryReport();
        }
    }
}
