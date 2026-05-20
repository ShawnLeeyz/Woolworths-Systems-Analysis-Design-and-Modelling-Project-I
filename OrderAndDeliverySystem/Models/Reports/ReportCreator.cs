using System;

namespace OrderAndDeliverySystem.Models.Reports
    {
    // ReportCreator defines how report are used
    public abstract class ReportCreator
    {
        public abstract Report CreateReport(); // variable to hold the type of report being created

        // method to build the report by calling the CreateReport method and then generating the report
        public Report BuildReport()
        {
            Report report = CreateReport();
            report.ReportData = report.Generate();
            return report;
        }
}
}
