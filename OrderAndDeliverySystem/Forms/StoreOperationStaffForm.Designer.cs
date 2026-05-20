namespace OrderAndDeliverySystem.Forms
{
    partial class StoreOperationStaffForm
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
            dgvTasks = new DataGridView();
            btnInProgress = new Button();
            btnCompleted = new Button();
            btnRefresh = new Button();
            lstNotifications = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(12, 64);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(364, 374);
            dgvTasks.TabIndex = 0;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = SystemColors.ActiveBorder;
            btnInProgress.Location = new Point(399, 102);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(121, 25);
            btnInProgress.TabIndex = 1;
            btnInProgress.Text = "Mark In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            btnInProgress.Click += btnInProgress_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = SystemColors.ActiveBorder;
            btnCompleted.Location = new Point(399, 147);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(121, 25);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "Mark Completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveBorder;
            btnRefresh.Location = new Point(399, 204);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 25);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lstNotifications
            // 
            lstNotifications.FormattingEnabled = true;
            lstNotifications.Location = new Point(545, 59);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new Size(227, 379);
            lstNotifications.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 6;
            label1.Text = "My Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(545, 15);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 7;
            label2.Text = "Notifications";
            // 
            // StoreOperationStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNotifications);
            Controls.Add(btnRefresh);
            Controls.Add(btnCompleted);
            Controls.Add(btnInProgress);
            Controls.Add(dgvTasks);
            Name = "StoreOperationStaffForm";
            Text = "StoreOperationStaffForm";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasks;
        private Button btnInProgress;
        private Button btnCompleted;
        private Button btnRefresh;
        private ListBox lstNotifications;
        private Label label1;
        private Label label2;
    }
}