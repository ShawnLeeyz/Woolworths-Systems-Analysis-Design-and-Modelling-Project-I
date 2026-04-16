using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Reports
{
    public abstract class Report
    {
        private int reportID;
        private DateTime dateGenerated;
        private Staff generatedBy;
        private string title;
        private string reportData;

        public Report() { }

        public int GetReportID()
        {
            return reportID;
        }

        public DateTime GetDateGenerated()
        {
            return dateGenerated;
        }

        public abstract void Generate();
    }
}
