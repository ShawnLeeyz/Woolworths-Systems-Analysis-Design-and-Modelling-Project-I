namespace OrderAndDeliverySystem.Forms
{
    partial class ReassignTaskForm
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
            cmbTask = new ComboBox();
            label2 = new Label();
            cmbStaff = new ComboBox();
            btnReassign = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Task:";
            // 
            // cmbTask
            // 
            cmbTask.FormattingEnabled = true;
            cmbTask.Location = new Point(31, 71);
            cmbTask.Name = "cmbTask";
            cmbTask.Size = new Size(164, 23);
            cmbTask.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 137);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Reassign To:";
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(31, 174);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(164, 23);
            cmbStaff.TabIndex = 3;
            // 
            // btnReassign
            // 
            btnReassign.BackColor = SystemColors.ActiveBorder;
            btnReassign.Location = new Point(31, 264);
            btnReassign.Name = "btnReassign";
            btnReassign.Size = new Size(75, 23);
            btnReassign.TabIndex = 4;
            btnReassign.Text = "Reassign";
            btnReassign.UseVisualStyleBackColor = false;
            btnReassign.Click += btnReassign_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(120, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReassignTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnReassign);
            Controls.Add(cmbStaff);
            Controls.Add(label2);
            Controls.Add(cmbTask);
            Controls.Add(label1);
            Name = "ReassignTaskForm";
            Text = "ReassignTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTask;
        private Label label2;
        private ComboBox cmbStaff;
        private Button btnReassign;
        private Button btnCancel;
    }
}