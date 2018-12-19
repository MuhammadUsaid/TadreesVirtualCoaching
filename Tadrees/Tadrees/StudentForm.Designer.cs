namespace Tadrees
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.studentGroupSearch = new System.Windows.Forms.GroupBox();
            this.SearchClassLLabelTeacher = new System.Windows.Forms.Label();
            this.StudentLabelAdd = new System.Windows.Forms.Button();
            this.SearchClassComboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.SearchClassLabelClassLevel = new System.Windows.Forms.Label();
            this.SearchClassComboBoxClassLevel = new System.Windows.Forms.ComboBox();
            this.SearchClassLLabelSubjects = new System.Windows.Forms.Label();
            this.SearchClassComboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.SearchClassLabelBoradName = new System.Windows.Forms.Label();
            this.SearchClassComboBoxBoardName = new System.Windows.Forms.ComboBox();
            this.studentGroupAddCourse = new System.Windows.Forms.GroupBox();
            this.StudentLabelEnroll = new System.Windows.Forms.Button();
            this.studentGridAddCourse = new System.Windows.Forms.DataGridView();
            this.studentGridAddColumnCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroupDropCourse = new System.Windows.Forms.GroupBox();
            this.studentLabelDrop = new System.Windows.Forms.Button();
            this.studentGridDropCourse = new System.Windows.Forms.DataGridView();
            this.studentGridDropColumnCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroupSchedule = new System.Windows.Forms.GroupBox();
            this.StudentGridSchedule = new System.Windows.Forms.DataGridView();
            this.StudentGridScheduleClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGridScheduleubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGridScheduleTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGridScheduleTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGridScheduleDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLabelViewAttendance = new System.Windows.Forms.Button();
            this.studentLabelEditProfile = new System.Windows.Forms.Button();
            this.studentPictureBox = new System.Windows.Forms.PictureBox();
            this.studentLabelLogOut = new System.Windows.Forms.Button();
            this.studentLabelTitle = new System.Windows.Forms.Label();
            this.studentGroupSearch.SuspendLayout();
            this.studentGroupAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridAddCourse)).BeginInit();
            this.studentGroupDropCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridDropCourse)).BeginInit();
            this.studentGroupSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGroupSearch
            // 
            this.studentGroupSearch.Controls.Add(this.SearchClassLLabelTeacher);
            this.studentGroupSearch.Controls.Add(this.StudentLabelAdd);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxTeacher);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassLLabelSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelBoradName);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxBoardName);
            this.studentGroupSearch.Location = new System.Drawing.Point(57, 536);
            this.studentGroupSearch.Name = "studentGroupSearch";
            this.studentGroupSearch.Size = new System.Drawing.Size(476, 285);
            this.studentGroupSearch.TabIndex = 27;
            this.studentGroupSearch.TabStop = false;
            this.studentGroupSearch.Text = "Search Course";
            // 
            // SearchClassLLabelTeacher
            // 
            this.SearchClassLLabelTeacher.AutoSize = true;
            this.SearchClassLLabelTeacher.Location = new System.Drawing.Point(57, 209);
            this.SearchClassLLabelTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLLabelTeacher.Name = "SearchClassLLabelTeacher";
            this.SearchClassLLabelTeacher.Size = new System.Drawing.Size(57, 17);
            this.SearchClassLLabelTeacher.TabIndex = 28;
            this.SearchClassLLabelTeacher.Text = "Techer:";
            // 
            // StudentLabelAdd
            // 
            this.StudentLabelAdd.Location = new System.Drawing.Point(315, 239);
            this.StudentLabelAdd.Name = "StudentLabelAdd";
            this.StudentLabelAdd.Size = new System.Drawing.Size(129, 31);
            this.StudentLabelAdd.TabIndex = 18;
            this.StudentLabelAdd.Text = "Add Course";
            this.StudentLabelAdd.UseVisualStyleBackColor = true;
            // 
            // SearchClassComboBoxTeacher
            // 
            this.SearchClassComboBoxTeacher.FormattingEnabled = true;
            this.SearchClassComboBoxTeacher.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.SearchClassComboBoxTeacher.Location = new System.Drawing.Point(172, 199);
            this.SearchClassComboBoxTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxTeacher.Name = "SearchClassComboBoxTeacher";
            this.SearchClassComboBoxTeacher.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxTeacher.TabIndex = 29;
            // 
            // SearchClassLabelClassLevel
            // 
            this.SearchClassLabelClassLevel.AutoSize = true;
            this.SearchClassLabelClassLevel.Location = new System.Drawing.Point(57, 147);
            this.SearchClassLabelClassLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelClassLevel.Name = "SearchClassLabelClassLevel";
            this.SearchClassLabelClassLevel.Size = new System.Drawing.Size(84, 17);
            this.SearchClassLabelClassLevel.TabIndex = 26;
            this.SearchClassLabelClassLevel.Text = "Class Level:";
            // 
            // SearchClassComboBoxClassLevel
            // 
            this.SearchClassComboBoxClassLevel.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.SearchClassComboBoxClassLevel.Location = new System.Drawing.Point(172, 147);
            this.SearchClassComboBoxClassLevel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxClassLevel.Name = "SearchClassComboBoxClassLevel";
            this.SearchClassComboBoxClassLevel.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxClassLevel.TabIndex = 27;
            // 
            // SearchClassLLabelSubjects
            // 
            this.SearchClassLLabelSubjects.AutoSize = true;
            this.SearchClassLLabelSubjects.Location = new System.Drawing.Point(57, 91);
            this.SearchClassLLabelSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLLabelSubjects.Name = "SearchClassLLabelSubjects";
            this.SearchClassLLabelSubjects.Size = new System.Drawing.Size(66, 17);
            this.SearchClassLLabelSubjects.TabIndex = 24;
            this.SearchClassLLabelSubjects.Text = "Subjects:";
            // 
            // SearchClassComboBoxSubjects
            // 
            this.SearchClassComboBoxSubjects.FormattingEnabled = true;
            this.SearchClassComboBoxSubjects.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.SearchClassComboBoxSubjects.Location = new System.Drawing.Point(172, 81);
            this.SearchClassComboBoxSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxSubjects.Name = "SearchClassComboBoxSubjects";
            this.SearchClassComboBoxSubjects.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxSubjects.TabIndex = 25;
            // 
            // SearchClassLabelBoradName
            // 
            this.SearchClassLabelBoradName.AutoSize = true;
            this.SearchClassLabelBoradName.Location = new System.Drawing.Point(57, 32);
            this.SearchClassLabelBoradName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelBoradName.Name = "SearchClassLabelBoradName";
            this.SearchClassLabelBoradName.Size = new System.Drawing.Size(91, 17);
            this.SearchClassLabelBoradName.TabIndex = 22;
            this.SearchClassLabelBoradName.Text = "Board Name:";
            // 
            // SearchClassComboBoxBoardName
            // 
            this.SearchClassComboBoxBoardName.FormattingEnabled = true;
            this.SearchClassComboBoxBoardName.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.SearchClassComboBoxBoardName.Location = new System.Drawing.Point(172, 28);
            this.SearchClassComboBoxBoardName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxBoardName.Name = "SearchClassComboBoxBoardName";
            this.SearchClassComboBoxBoardName.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxBoardName.TabIndex = 23;
            // 
            // studentGroupAddCourse
            // 
            this.studentGroupAddCourse.Controls.Add(this.StudentLabelEnroll);
            this.studentGroupAddCourse.Controls.Add(this.studentGridAddCourse);
            this.studentGroupAddCourse.Location = new System.Drawing.Point(287, 843);
            this.studentGroupAddCourse.Name = "studentGroupAddCourse";
            this.studentGroupAddCourse.Size = new System.Drawing.Size(438, 186);
            this.studentGroupAddCourse.TabIndex = 26;
            this.studentGroupAddCourse.TabStop = false;
            this.studentGroupAddCourse.Text = "Add Course";
            // 
            // StudentLabelEnroll
            // 
            this.StudentLabelEnroll.Location = new System.Drawing.Point(266, 149);
            this.StudentLabelEnroll.Name = "StudentLabelEnroll";
            this.StudentLabelEnroll.Size = new System.Drawing.Size(129, 31);
            this.StudentLabelEnroll.TabIndex = 30;
            this.StudentLabelEnroll.Text = "Enroll";
            this.StudentLabelEnroll.UseVisualStyleBackColor = true;
            // 
            // studentGridAddCourse
            // 
            this.studentGridAddCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridAddCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentGridAddColumnCourses});
            this.studentGridAddCourse.Location = new System.Drawing.Point(26, 30);
            this.studentGridAddCourse.Name = "studentGridAddCourse";
            this.studentGridAddCourse.RowTemplate.Height = 24;
            this.studentGridAddCourse.Size = new System.Drawing.Size(382, 105);
            this.studentGridAddCourse.TabIndex = 15;
            // 
            // studentGridAddColumnCourses
            // 
            this.studentGridAddColumnCourses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentGridAddColumnCourses.HeaderText = "Courses";
            this.studentGridAddColumnCourses.Name = "studentGridAddColumnCourses";
            // 
            // studentGroupDropCourse
            // 
            this.studentGroupDropCourse.Controls.Add(this.studentLabelDrop);
            this.studentGroupDropCourse.Controls.Add(this.studentGridDropCourse);
            this.studentGroupDropCourse.Location = new System.Drawing.Point(585, 536);
            this.studentGroupDropCourse.Name = "studentGroupDropCourse";
            this.studentGroupDropCourse.Size = new System.Drawing.Size(315, 285);
            this.studentGroupDropCourse.TabIndex = 28;
            this.studentGroupDropCourse.TabStop = false;
            this.studentGroupDropCourse.Text = "Drop Course";
            // 
            // studentLabelDrop
            // 
            this.studentLabelDrop.Location = new System.Drawing.Point(148, 229);
            this.studentLabelDrop.Name = "studentLabelDrop";
            this.studentLabelDrop.Size = new System.Drawing.Size(129, 31);
            this.studentLabelDrop.TabIndex = 19;
            this.studentLabelDrop.Text = "Drop Course";
            this.studentLabelDrop.UseVisualStyleBackColor = true;
            // 
            // studentGridDropCourse
            // 
            this.studentGridDropCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridDropCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentGridDropColumnCourses});
            this.studentGridDropCourse.Location = new System.Drawing.Point(32, 41);
            this.studentGridDropCourse.Name = "studentGridDropCourse";
            this.studentGridDropCourse.RowTemplate.Height = 24;
            this.studentGridDropCourse.Size = new System.Drawing.Size(256, 170);
            this.studentGridDropCourse.TabIndex = 15;
            // 
            // studentGridDropColumnCourses
            // 
            this.studentGridDropColumnCourses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentGridDropColumnCourses.HeaderText = "Courses";
            this.studentGridDropColumnCourses.Name = "studentGridDropColumnCourses";
            // 
            // studentGroupSchedule
            // 
            this.studentGroupSchedule.Controls.Add(this.StudentGridSchedule);
            this.studentGroupSchedule.Location = new System.Drawing.Point(197, 208);
            this.studentGroupSchedule.Name = "studentGroupSchedule";
            this.studentGroupSchedule.Size = new System.Drawing.Size(623, 308);
            this.studentGroupSchedule.TabIndex = 25;
            this.studentGroupSchedule.TabStop = false;
            this.studentGroupSchedule.Text = "Schedule";
            // 
            // StudentGridSchedule
            // 
            this.StudentGridSchedule.AllowUserToAddRows = false;
            this.StudentGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentGridScheduleClassID,
            this.StudentGridScheduleubject,
            this.StudentGridScheduleTeacher,
            this.StudentGridScheduleTimings,
            this.StudentGridScheduleDays});
            this.StudentGridSchedule.Location = new System.Drawing.Point(17, 38);
            this.StudentGridSchedule.Name = "StudentGridSchedule";
            this.StudentGridSchedule.RowTemplate.Height = 24;
            this.StudentGridSchedule.Size = new System.Drawing.Size(582, 220);
            this.StudentGridSchedule.TabIndex = 14;
            // 
            // StudentGridScheduleClassID
            // 
            this.StudentGridScheduleClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGridScheduleClassID.HeaderText = "ClassID";
            this.StudentGridScheduleClassID.Name = "StudentGridScheduleClassID";
            // 
            // StudentGridScheduleubject
            // 
            this.StudentGridScheduleubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGridScheduleubject.HeaderText = "Subject";
            this.StudentGridScheduleubject.Name = "StudentGridScheduleubject";
            // 
            // StudentGridScheduleTeacher
            // 
            this.StudentGridScheduleTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGridScheduleTeacher.HeaderText = "Teacher";
            this.StudentGridScheduleTeacher.Name = "StudentGridScheduleTeacher";
            // 
            // StudentGridScheduleTimings
            // 
            this.StudentGridScheduleTimings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGridScheduleTimings.HeaderText = "Timings";
            this.StudentGridScheduleTimings.Name = "StudentGridScheduleTimings";
            // 
            // StudentGridScheduleDays
            // 
            this.StudentGridScheduleDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGridScheduleDays.HeaderText = "Days";
            this.StudentGridScheduleDays.Name = "StudentGridScheduleDays";
            // 
            // studentLabelViewAttendance
            // 
            this.studentLabelViewAttendance.Location = new System.Drawing.Point(558, 152);
            this.studentLabelViewAttendance.Name = "studentLabelViewAttendance";
            this.studentLabelViewAttendance.Size = new System.Drawing.Size(210, 33);
            this.studentLabelViewAttendance.TabIndex = 24;
            this.studentLabelViewAttendance.Text = "View Attendance";
            this.studentLabelViewAttendance.UseVisualStyleBackColor = true;
            // 
            // studentLabelEditProfile
            // 
            this.studentLabelEditProfile.Location = new System.Drawing.Point(251, 152);
            this.studentLabelEditProfile.Name = "studentLabelEditProfile";
            this.studentLabelEditProfile.Size = new System.Drawing.Size(210, 33);
            this.studentLabelEditProfile.TabIndex = 23;
            this.studentLabelEditProfile.Text = "Edit Profile";
            this.studentLabelEditProfile.UseVisualStyleBackColor = true;
            // 
            // studentPictureBox
            // 
            this.studentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("studentPictureBox.Image")));
            this.studentPictureBox.Location = new System.Drawing.Point(57, 16);
            this.studentPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentPictureBox.Name = "studentPictureBox";
            this.studentPictureBox.Size = new System.Drawing.Size(152, 159);
            this.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPictureBox.TabIndex = 22;
            this.studentPictureBox.TabStop = false;
            // 
            // studentLabelLogOut
            // 
            this.studentLabelLogOut.Location = new System.Drawing.Point(924, 82);
            this.studentLabelLogOut.Name = "studentLabelLogOut";
            this.studentLabelLogOut.Size = new System.Drawing.Size(109, 32);
            this.studentLabelLogOut.TabIndex = 30;
            this.studentLabelLogOut.Text = "Log Out";
            this.studentLabelLogOut.UseVisualStyleBackColor = true;
            // 
            // studentLabelTitle
            // 
            this.studentLabelTitle.AutoSize = true;
            this.studentLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.studentLabelTitle.ForeColor = System.Drawing.Color.Teal;
            this.studentLabelTitle.Location = new System.Drawing.Point(224, 66);
            this.studentLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentLabelTitle.Name = "studentLabelTitle";
            this.studentLabelTitle.Size = new System.Drawing.Size(697, 67);
            this.studentLabelTitle.TabIndex = 29;
            this.studentLabelTitle.Text = "Tadrees Virtual Coaching";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 1040);
            this.Controls.Add(this.studentLabelLogOut);
            this.Controls.Add(this.studentLabelTitle);
            this.Controls.Add(this.studentGroupSearch);
            this.Controls.Add(this.studentGroupAddCourse);
            this.Controls.Add(this.studentGroupDropCourse);
            this.Controls.Add(this.studentGroupSchedule);
            this.Controls.Add(this.studentLabelViewAttendance);
            this.Controls.Add(this.studentLabelEditProfile);
            this.Controls.Add(this.studentPictureBox);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.studentGroupSearch.ResumeLayout(false);
            this.studentGroupSearch.PerformLayout();
            this.studentGroupAddCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridAddCourse)).EndInit();
            this.studentGroupDropCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridDropCourse)).EndInit();
            this.studentGroupSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupSearch;
        private System.Windows.Forms.Label SearchClassLLabelTeacher;
        private System.Windows.Forms.Button StudentLabelAdd;
        private System.Windows.Forms.ComboBox SearchClassComboBoxTeacher;
        private System.Windows.Forms.Label SearchClassLabelClassLevel;
        private System.Windows.Forms.ComboBox SearchClassComboBoxClassLevel;
        private System.Windows.Forms.Label SearchClassLLabelSubjects;
        private System.Windows.Forms.ComboBox SearchClassComboBoxSubjects;
        private System.Windows.Forms.Label SearchClassLabelBoradName;
        private System.Windows.Forms.ComboBox SearchClassComboBoxBoardName;
        private System.Windows.Forms.GroupBox studentGroupAddCourse;
        private System.Windows.Forms.Button StudentLabelEnroll;
        private System.Windows.Forms.DataGridView studentGridAddCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGridAddColumnCourses;
        private System.Windows.Forms.GroupBox studentGroupDropCourse;
        private System.Windows.Forms.Button studentLabelDrop;
        private System.Windows.Forms.DataGridView studentGridDropCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGridDropColumnCourses;
        private System.Windows.Forms.GroupBox studentGroupSchedule;
        private System.Windows.Forms.DataGridView StudentGridSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGridScheduleClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGridScheduleubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGridScheduleTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGridScheduleTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGridScheduleDays;
        private System.Windows.Forms.Button studentLabelViewAttendance;
        private System.Windows.Forms.Button studentLabelEditProfile;
        private System.Windows.Forms.PictureBox studentPictureBox;
        private System.Windows.Forms.Button studentLabelLogOut;
        private System.Windows.Forms.Label studentLabelTitle;
    }
}