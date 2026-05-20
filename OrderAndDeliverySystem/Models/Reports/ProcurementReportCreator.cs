using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Reports
{

    // This class is responsible for creating instances of ProcurementReport
    public class ProcurementReportCreator : ReportCreator
    {
        public override Report CreateReport()
        {
            return new ProcurementReport();
        }
    }
}
