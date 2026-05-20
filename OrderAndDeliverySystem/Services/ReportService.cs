using OrderAndDeliverySystem.Models.Reports;

namespace OrderAndDeliverySystem.Services
{
    // This class is the mediator between the UI and the factory creators,
    // containing the business logic for generating reports
    public class ReportService
    {
        // Generates an InventoryReport using the Factory Method pattern
        public Report GenerateInventoryReport()
        {
            ReportCreator creator = new InventoryReportCreator();
            return creator.CreateReport();
        }

        // Generates a ProcurementReport using the Factory Method pattern
        public Report GenerateProcurementReport()
        {
            ReportCreator creator = new ProcurementReportCreator();
            return creator.CreateReport();
        }
    }
}