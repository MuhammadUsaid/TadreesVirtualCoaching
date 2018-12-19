namespace Tadrees
{
    partial class ViewAttendance
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
            this.ViewAttendancebuttonView = new System.Windows.Forms.Button();
            this.ViewAttendancedataGridView = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewAttendancecomboBoxClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAttendancedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAttendancebuttonView
            // 
            this.ViewAttendancebuttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendancebuttonView.Location = new System.Drawing.Point(441, 224);
            this.ViewAttendancebuttonView.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAttendancebuttonView.Name = "ViewAttendancebuttonView";
            this.ViewAttendancebuttonView.Size = new System.Drawing.Size(104, 34);
            this.ViewAttendancebuttonView.TabIndex = 68;
            this.ViewAttendancebuttonView.Text = "View";
            this.ViewAttendancebuttonView.UseVisualStyleBackColor = true;
            // 
            // ViewAttendancedataGridView
            // 
            this.ViewAttendancedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAttendancedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.Status,
            this.Date});
            this.ViewAttendancedataGridView.Location = new System.Drawing.Point(33, 280);
            this.ViewAttendancedataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAttendancedataGridView.Name = "ViewAttendancedataGridView";
            this.ViewAttendancedataGridView.Size = new System.Drawing.Size(935, 367);
            this.ViewAttendancedataGridView.TabIndex = 67;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "Class ID";
            this.ClassID.Name = "ClassID";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // ViewAttendancecomboBoxClass
            // 
            this.ViewAttendancecomboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendancecomboBoxClass.FormattingEnabled = true;
            this.ViewAttendancecomboBoxClass.Items.AddRange(new object[] {
            "First Year\t",
            "Second Year",
            "Third Year",
            "Final Year"});
            this.ViewAttendancecomboBoxClass.Location = new System.Drawing.Point(453, 145);
            this.ViewAttendancecomboBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAttendancecomboBoxClass.Name = "ViewAttendancecomboBoxClass";
            this.ViewAttendancecomboBoxClass.Size = new System.Drawing.Size(160, 28);
            this.ViewAttendancecomboBoxClass.TabIndex = 66;
            this.ViewAttendancecomboBoxClass.Text = "--Select Year--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Class";
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 728);
            this.Controls.Add(this.ViewAttendancebuttonView);
            this.Controls.Add(this.ViewAttendancedataGridView);
            this.Controls.Add(this.ViewAttendancecomboBoxClass);
            this.Controls.Add(this.label2);
            this.Name = "ViewAttendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAttendancedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewAttendancebuttonView;
        private System.Windows.Forms.DataGridView ViewAttendancedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ComboBox ViewAttendancecomboBoxClass;
        private System.Windows.Forms.Label label2;
    }
}