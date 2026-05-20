namespace OrderAndDeliverySystem.Forms
{
    partial class ProcurementSpecialistForm
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
            lblStockLevels = new Label();
            txtStockLevels = new TextBox();
            lblDemandTrends = new Label();
            txtDemandTrends = new TextBox();
            lblOutstandingPOs = new Label();
            txtOutstandingPOs = new TextBox();
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
            label1.Text = "Procurement Specialist";
            // 
            // lblStockLevels
            // 
            lblStockLevels.AutoSize = true;
            lblStockLevels.Font = new Font("Segoe UI", 10F);
            lblStockLevels.Location = new Point(12, 60);
            lblStockLevels.Name = "lblStockLevels";
            lblStockLevels.Size = new Size(63, 21);
            lblStockLevels.TabIndex = 1;
            lblStockLevels.Text = "Stock Levels:";
            // 
            // txtStockLevels
            // 
            txtStockLevels.Location = new Point(200, 58);
            txtStockLevels.Name = "txtStockLevels";
            txtStockLevels.Size = new Size(440, 23);
            txtStockLevels.TabIndex = 2;
            // 
            // lblDemandTrends
            // 
            lblDemandTrends.AutoSize = true;
            lblDemandTrends.Font = new Font("Segoe UI", 10F);
            lblDemandTrends.Location = new Point(12, 104);
            lblDemandTrends.Name = "lblDemandTrends";
            lblDemandTrends.Size = new Size(63, 21);
            lblDemandTrends.TabIndex = 3;
            lblDemandTrends.Text = "Demand Trends:";
            // 
            // txtDemandTrends
            // 
            txtDemandTrends.Location = new Point(200, 102);
            txtDemandTrends.Name = "txtDemandTrends";
            txtDemandTrends.Size = new Size(440, 23);
            txtDemandTrends.TabIndex = 4;
            // 
            // lblOutstandingPOs
            // 
            lblOutstandingPOs.AutoSize = true;
            lblOutstandingPOs.Font = new Font("Segoe UI", 10F);
            lblOutstandingPOs.Location = new Point(12, 148);
            lblOutstandingPOs.Name = "lblOutstandingPOs";
            lblOutstandingPOs.Size = new Size(63, 21);
            lblOutstandingPOs.TabIndex = 5;
            lblOutstandingPOs.Text = "Outstanding POs:";
            // 
            // txtOutstandingPOs
            // 
            txtOutstandingPOs.Location = new Point(200, 146);
            txtOutstandingPOs.Name = "txtOutstandingPOs";
            txtOutstandingPOs.Size = new Size(440, 23);
            txtOutstandingPOs.TabIndex = 6;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.ActiveBorder;
            btnGenerateReport.Location = new Point(12, 190);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 34);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Location = new Point(172, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 10F);
            lblOutput.Location = new Point(12, 240);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(63, 21);
            lblOutput.TabIndex = 9;
            lblOutput.Text = "Generated Report Output:";
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(12, 265);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(760, 160);
            rtbOutput.TabIndex = 10;
            rtbOutput.ReadOnly = true;
            rtbOutput.Font = new Font("Consolas", 10F);
            rtbOutput.BackColor = SystemColors.ControlLight;
            // 
            // ProcurementSpecialistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbOutput);
            Controls.Add(lblOutput);
            Controls.Add(btnClear);
            Controls.Add(btnGenerateReport);
            Controls.Add(txtOutstandingPOs);
            Controls.Add(lblOutstandingPOs);
            Controls.Add(txtDemandTrends);
            Controls.Add(lblDemandTrends);
            Controls.Add(txtStockLevels);
            Controls.Add(lblStockLevels);
            Controls.Add(label1);
            Name = "ProcurementSpecialistForm";
            Text = "ProcurementSpecialistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStockLevels;
        private TextBox txtStockLevels;
        private Label lblDemandTrends;
        private TextBox txtDemandTrends;
        private Label lblOutstandingPOs;
        private TextBox txtOutstandingPOs;
        private Button btnGenerateReport;
        private Button btnClear;
        private Label lblOutput;
        private RichTextBox rtbOutput;
    }
}