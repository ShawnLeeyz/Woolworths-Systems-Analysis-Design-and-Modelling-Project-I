using System;
using System.Windows.Forms;
using OrderAndDeliverySystem.Services;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Reports;

namespace OrderAndDeliverySystem.Forms
{
    public partial class InventoryControllerForm : Form
    {
        private ReportService reportService;
        private InventoryController inventoryController;

        public InventoryControllerForm(Staff staff)
        {
            InitializeComponent();
            reportService = new ReportService();
            inventoryController = (InventoryController)staff;
        }

        // Report button functionality where it generates an InventoryReport using the Factory Method pattern via ReportService and displays it
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Factory Method Pattern - ReportService delegates to InventoryReportCreator
            Report report = reportService.GenerateInventoryReport();
            InventoryReport inventoryReport = (InventoryReport)report;

            // Get input from fields and set to report
            inventoryReport.RankedProducts      = txtRankedProducts.Text.Trim();
            inventoryReport.RestockFrequency    = txtRestockFrequency.Text.Trim();
            inventoryReport.CurrentStockSummary = txtCurrentStockSummary.Text.Trim();
            inventoryReport.StoreLocations      = txtStoreLocations.Text.Trim();
            inventoryReport.ReportPeriod        = txtReportPeriod.Text.Trim();

            // Generate and display the report
            inventoryReport.ReportData = inventoryReport.Generate();
            rtbOutput.Clear();
            rtbOutput.AppendText($"[Factory Method Pattern]\r\n");
            rtbOutput.AppendText($"Creator Used : InventoryReportCreator\r\n");
            rtbOutput.AppendText($"Generated At : {DateTime.Now:dd MMM yyyy HH:mm:ss}\r\n");
            rtbOutput.AppendText($"─────────────────────────────────────────\r\n");
            rtbOutput.AppendText(inventoryReport.ReportData);
        }

        // Clear button - clears all input fields and output
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRankedProducts.Clear();
            txtRestockFrequency.Clear();
            txtCurrentStockSummary.Clear();
            txtStoreLocations.Clear();
            txtReportPeriod.Clear();
            rtbOutput.Clear();
        }
    }
}