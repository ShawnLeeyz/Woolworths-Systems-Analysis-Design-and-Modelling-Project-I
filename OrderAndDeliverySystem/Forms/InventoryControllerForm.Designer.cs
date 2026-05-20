namespace OrderAndDeliverySystem.Forms
{
    partial class InventoryControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblRankedProducts = new Label();
            txtRankedProducts = new TextBox();
            lblRestockFrequency = new Label();
            txtRestockFrequency = new TextBox();
            lblCurrentStockSummary = new Label();
            txtCurrentStockSummary = new TextBox();
            lblStoreLocations = new Label();
            txtStoreLocations = new TextBox();
            lblReportPeriod = new Label();
            txtReportPeriod = new TextBox();
            btnGenerateReport = new Button();
            btnClear = new Button();
            lblOutput = new Label();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 0;
            label1.Text = "Inventory Controller";
            // 
            // lblRankedProducts
            // 
            lblRankedProducts.AutoSize = true;
            lblRankedProducts.Font = new Font("Segoe UI", 10F);
            lblRankedProducts.Location = new Point(12, 60);
            lblRankedProducts.Name = "lblRankedProducts";
            lblRankedProducts.Size = new Size(63, 21);
            lblRankedProducts.TabIndex = 1;
            lblRankedProducts.Text = "Ranked Products:";
            // 
            // txtRankedProducts
            // 
            txtRankedProducts.Location = new Point(200, 58);
            txtRankedProducts.Name = "txtRankedProducts";
            txtRankedProducts.Size = new Size(440, 23);
            txtRankedProducts.TabIndex = 2;
            // 
            // lblRestockFrequency
            // 
            lblRestockFrequency.AutoSize = true;
            lblRestockFrequency.Font = new Font("Segoe UI", 10F);
            lblRestockFrequency.Location = new Point(12, 100);
            lblRestockFrequency.Name = "lblRestockFrequency";
            lblRestockFrequency.Size = new Size(63, 21);
            lblRestockFrequency.TabIndex = 3;
            lblRestockFrequency.Text = "Restock Frequency:";
            // 
            // txtRestockFrequency
            // 
            txtRestockFrequency.Location = new Point(200, 98);
            txtRestockFrequency.Name = "txtRestockFrequency";
            txtRestockFrequency.Size = new Size(440, 23);
            txtRestockFrequency.TabIndex = 4;
            // 
            // lblCurrentStockSummary
            // 
            lblCurrentStockSummary.AutoSize = true;
            lblCurrentStockSummary.Font = new Font("Segoe UI", 10F);
            lblCurrentStockSummary.Location = new Point(12, 140);
            lblCurrentStockSummary.Name = "lblCurrentStockSummary";
            lblCurrentStockSummary.Size = new Size(63, 21);
            lblCurrentStockSummary.TabIndex = 5;
            lblCurrentStockSummary.Text = "Current Stock Summary:";
            // 
            // txtCurrentStockSummary
            // 
            txtCurrentStockSummary.Location = new Point(200, 138);
            txtCurrentStockSummary.Name = "txtCurrentStockSummary";
            txtCurrentStockSummary.Size = new Size(440, 23);
            txtCurrentStockSummary.TabIndex = 6;
            // 
            // lblStoreLocations
            // 
            lblStoreLocations.AutoSize = true;
            lblStoreLocations.Font = new Font("Segoe UI", 10F);
            lblStoreLocations.Location = new Point(12, 180);
            lblStoreLocations.Name = "lblStoreLocations";
            lblStoreLocations.Size = new Size(63, 21);
            lblStoreLocations.TabIndex = 7;
            lblStoreLocations.Text = "Store Locations:";
            // 
            // txtStoreLocations
            // 
            txtStoreLocations.Location = new Point(200, 178);
            txtStoreLocations.Name = "txtStoreLocations";
            txtStoreLocations.Size = new Size(440, 23);
            txtStoreLocations.TabIndex = 8;
            // 
            // lblReportPeriod
            // 
            lblReportPeriod.AutoSize = true;
            lblReportPeriod.Font = new Font("Segoe UI", 10F);
            lblReportPeriod.Location = new Point(12, 220);
            lblReportPeriod.Name = "lblReportPeriod";
            lblReportPeriod.Size = new Size(63, 21);
            lblReportPeriod.TabIndex = 9;
            lblReportPeriod.Text = "Report Period:";
            // 
            // txtReportPeriod
            // 
            txtReportPeriod.Location = new Point(200, 218);
            txtReportPeriod.Name = "txtReportPeriod";
            txtReportPeriod.Size = new Size(440, 23);
            txtReportPeriod.TabIndex = 10;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.ActiveBorder;
            btnGenerateReport.Location = new Point(12, 260);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 34);
            btnGenerateReport.TabIndex = 11;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Location = new Point(172, 260);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 10F);
            lblOutput.Location = new Point(12, 310);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(63, 21);
            lblOutput.TabIndex = 13;
            lblOutput.Text = "Generated Report Output:";
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(12, 335);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(760, 100);
            rtbOutput.TabIndex = 14;
            rtbOutput.ReadOnly = true;
            rtbOutput.Font = new Font("Consolas", 10F);
            rtbOutput.BackColor = SystemColors.ControlLight;
            // 
            // InventoryControllerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbOutput);
            Controls.Add(lblOutput);
            Controls.Add(btnClear);
            Controls.Add(btnGenerateReport);
            Controls.Add(txtReportPeriod);
            Controls.Add(lblReportPeriod);
            Controls.Add(txtStoreLocations);
            Controls.Add(lblStoreLocations);
            Controls.Add(txtCurrentStockSummary);
            Controls.Add(lblCurrentStockSummary);
            Controls.Add(txtRestockFrequency);
            Controls.Add(lblRestockFrequency);
            Controls.Add(txtRankedProducts);
            Controls.Add(lblRankedProducts);
            Controls.Add(label1);
            Name = "InventoryControllerForm";
            Text = "InventoryControllerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRankedProducts;
        private TextBox txtRankedProducts;
        private Label lblRestockFrequency;
        private TextBox txtRestockFrequency;
        private Label lblCurrentStockSummary;
        private TextBox txtCurrentStockSummary;
        private Label lblStoreLocations;
        private TextBox txtStoreLocations;
        private Label lblReportPeriod;
        private TextBox txtReportPeriod;
        private Button btnGenerateReport;
        private Button btnClear;
        private Label lblOutput;
        private RichTextBox rtbOutput;
    }
}