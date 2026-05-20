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

        // This constructor is used for the factory method pattern, allowing for the creation of reports without needing to specify all details upfront
        public Report() 
        { 
            this.dateGenerated = DateTime.Now;
        }
        public Report(int reportID, Staff generatedBy, string title, string reportData)
        {
            this.reportID     = reportID;
            this.dateGenerated = DateTime.Now; // Automatically set to current date and time when the report is created
            this.generatedBy = generatedBy;
            this.title        = title;
            this.reportData   = reportData;

        }
        public int ReportID
        {
            get { return reportID; }
        }

        public DateTime DateGenerated
        {
            get { return dateGenerated; }
            set { dateGenerated = value; }
        }

        public Staff GeneratedBy
        {
            get { return generatedBy; }
            set { generatedBy = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string ReportData
        {
            get { return reportData; }
            set { reportData = value; }
        }

        public abstract string Generate();
    }
}
