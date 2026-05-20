namespace OrderAndDeliverySystem.Forms
{
    partial class AssignTaskForm
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
            txtDescription = new TextBox();
            label2 = new Label();
            dtpDeadline = new DateTimePicker();
            label3 = new Label();
            cmbStaff = new ComboBox();
            btnAssign = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 45);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(328, 23);
            txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Deadline:";
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(12, 122);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(200, 23);
            dtpDeadline.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Assign To:";
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(12, 205);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(121, 23);
            cmbStaff.TabIndex = 5;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = SystemColors.ActiveBorder;
            btnAssign.Location = new Point(24, 278);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(75, 23);
            btnAssign.TabIndex = 6;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(137, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AssignTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAssign);
            Controls.Add(cmbStaff);
            Controls.Add(label3);
            Controls.Add(dtpDeadline);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "AssignTaskForm";
            Text = "AssignTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private DateTimePicker dtpDeadline;
        private Label label3;
        private ComboBox cmbStaff;
        private Button btnAssign;
        private Button btnCancel;
    }
}