namespace OrderAndDeliverySystem.Forms
{
    partial class ShiftManagerForm
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
            btnAssignTask = new Button();
            btnReassignTask = new Button();
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
            dgvTasks.Location = new Point(12, 42);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(365, 396);
            dgvTasks.TabIndex = 0;
            // 
            // btnAssignTask
            // 
            btnAssignTask.BackColor = SystemColors.ActiveBorder;
            btnAssignTask.Location = new Point(396, 42);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(95, 34);
            btnAssignTask.TabIndex = 1;
            btnAssignTask.Text = "Assign Task";
            btnAssignTask.UseVisualStyleBackColor = false;
            btnAssignTask.Click += btnAssignTask_Click;
            // 
            // btnReassignTask
            // 
            btnReassignTask.BackColor = SystemColors.ActiveBorder;
            btnReassignTask.Location = new Point(396, 107);
            btnReassignTask.Name = "btnReassignTask";
            btnReassignTask.Size = new Size(95, 34);
            btnReassignTask.TabIndex = 2;
            btnReassignTask.Text = "Reassign Task";
            btnReassignTask.UseVisualStyleBackColor = false;
            btnReassignTask.Click += btnReassignTask_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveBorder;
            btnRefresh.Location = new Point(396, 172);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lstNotifications
            // 
            lstNotifications.FormattingEnabled = true;
            lstNotifications.Location = new Point(668, 42);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new Size(120, 394);
            lstNotifications.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 5;
            label1.Text = "Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(664, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(133, 30);
            label2.TabIndex = 6;
            label2.Text = "Notifications";
            // 
            // ShiftManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNotifications);
            Controls.Add(btnRefresh);
            Controls.Add(btnReassignTask);
            Controls.Add(btnAssignTask);
            Controls.Add(dgvTasks);
            Name = "ShiftManagerForm";
            Text = "ShiftManagerForm";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasks;
        private Button btnAssignTask;
        private Button btnReassignTask;
        private Button btnRefresh;
        private ListBox lstNotifications;
        private Label label1;
        private Label label2;
    }
}