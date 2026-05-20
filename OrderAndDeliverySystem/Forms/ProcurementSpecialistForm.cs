using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Reports;

namespace OrderAndDeliverySystem.Forms
{
    public partial class ProcurementSpecialistForm : Form
    {
        private ReportService reportService;
        private ProcurementSpecialist procurementSpecialist;

        public ProcurementSpecialistForm(Staff staff)
        {
            InitializeComponent();
            reportService = new ReportService();
            procurementSpecialist = (ProcurementSpecialist)staff;
        }

        // Report button functionality where it generates an procurement report using the Factory Method pattern via ReportService and displays it
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Factory Method Pattern, ReportService delegates to ProcurementReportCreator
            Report report = reportService.GenerateProcurementReport();
            ProcurementReport procurementReport = (ProcurementReport)report;

            // Get input from fields and set to report
            procurementReport.StockLevels = txtStockLevels.Text.Trim();
            procurementReport.DemandTrends = txtDemandTrends.Text.Trim();
            procurementReport.OutstandingPOs = txtOutstandingPOs.Text.Trim();

            // Generate and display the report
            procurementReport.ReportData = procurementReport.Generate();
            rtbOutput.Clear();
            rtbOutput.AppendText($"Creator Used : ProcurementReportCreator\r\n");
            rtbOutput.AppendText($"Generated At : {DateTime.Now:dd MMM yyyy HH:mm:ss}\r\n");
            rtbOutput.AppendText($"─────────────────────────────────────────\r\n");
            rtbOutput.AppendText(procurementReport.ReportData);
        }

        // Clear all inputs from textfields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStockLevels.Clear();
            txtDemandTrends.Clear();
            txtOutstandingPOs.Clear();
            rtbOutput.Clear();
        }
    }
}