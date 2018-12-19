namespace Tadrees
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.studentGroupSearch = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StudentLabelAdd = new System.Windows.Forms.Button();
            this.SearchClassLabelClassLevel = new System.Windows.Forms.Label();
            this.SearchClassComboBoxClassLevel = new System.Windows.Forms.ComboBox();
            this.SearchClassLLabelSubjects = new System.Windows.Forms.Label();
            this.SearchClassLabelBoradName = new System.Windows.Forms.Label();
            this.SearchClassComboBoxBoardName = new System.Windows.Forms.ComboBox();
            this.studentGroupAddCourse = new System.Windows.Forms.GroupBox();
            this.StudentLabelEnroll = new System.Windows.Forms.Button();
            this.studentGridAddCourse = new System.Windows.Forms.DataGridView();
            this.studentGridAddColumnCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherLabelAttendance = new System.Windows.Forms.Button();
            this.studentGroupDropCourse = new System.Windows.Forms.GroupBox();
            this.studentLabelDrop = new System.Windows.Forms.Button();
            this.studentGridDropCourse = new System.Windows.Forms.DataGridView();
            this.studentGridDropColumnCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherLabelStartClass = new System.Windows.Forms.Button();
            this.teacherLabelViewAttendance = new System.Windows.Forms.Button();
            this.teacherLabelEditProfile = new System.Windows.Forms.Button();
            this.teacherPictureBox = new System.Windows.Forms.PictureBox();
            this.teacherGroupSchedule = new System.Windows.Forms.GroupBox();
            this.teacherGridSchedule = new System.Windows.Forms.DataGridView();
            this.teacherGridScheduleClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherGridScheduleubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherGridScheduleTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherGridScheduleTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherGridScheduleDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherLabelLogOut = new System.Windows.Forms.Button();
            this.teacherLabelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studentGroupSearch.SuspendLayout();
            this.studentGroupAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridAddCourse)).BeginInit();
            this.studentGroupDropCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridDropCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).BeginInit();
            this.teacherGroupSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGroupSearch
            // 
            this.studentGroupSearch.Controls.Add(this.textBox1);
            this.studentGroupSearch.Controls.Add(this.StudentLabelAdd);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassLLabelSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelBoradName);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxBoardName);
            this.studentGroupSearch.Location = new System.Drawing.Point(119, 466);
            this.studentGroupSearch.Name = "studentGroupSearch";
            this.studentGroupSearch.Size = new System.Drawing.Size(476, 288);
            this.studentGroupSearch.TabIndex = 31;
            this.studentGroupSearch.TabStop = false;
            this.studentGroupSearch.Text = "Search Course";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 28;
            // 
            // StudentLabelAdd
            // 
            this.StudentLabelAdd.Location = new System.Drawing.Point(307, 229);
            this.StudentLabelAdd.Name = "StudentLabelAdd";
            this.StudentLabelAdd.Size = new System.Drawing.Size(129, 31);
            this.StudentLabelAdd.TabIndex = 18;
            this.StudentLabelAdd.Text = "Add Course";
            this.StudentLabelAdd.UseVisualStyleBackColor = true;
            // 
            // SearchClassLabelClassLevel
            // 
            this.SearchClassLabelClassLevel.AutoSize = true;
            this.SearchClassLabelClassLevel.Location = new System.Drawing.Point(60, 170);
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
            this.SearchClassComboBoxClassLevel.Location = new System.Drawing.Point(175, 170);
            this.SearchClassComboBoxClassLevel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxClassLevel.Name = "SearchClassComboBoxClassLevel";
            this.SearchClassComboBoxClassLevel.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxClassLevel.TabIndex = 27;
            // 
            // SearchClassLLabelSubjects
            // 
            this.SearchClassLLabelSubjects.AutoSize = true;
            this.SearchClassLLabelSubjects.Location = new System.Drawing.Point(60, 114);
            this.SearchClassLLabelSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLLabelSubjects.Name = "SearchClassLLabelSubjects";
            this.SearchClassLLabelSubjects.Size = new System.Drawing.Size(66, 17);
            this.SearchClassLLabelSubjects.TabIndex = 24;
            this.SearchClassLLabelSubjects.Text = "Subjects:";
            // 
            // SearchClassLabelBoradName
            // 
            this.SearchClassLabelBoradName.AutoSize = true;
            this.SearchClassLabelBoradName.Location = new System.Drawing.Point(60, 55);
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
            this.SearchClassComboBoxBoardName.Location = new System.Drawing.Point(175, 51);
            this.SearchClassComboBoxBoardName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxBoardName.Name = "SearchClassComboBoxBoardName";
            this.SearchClassComboBoxBoardName.Size = new System.Drawing.Size(213, 24);
            this.SearchClassComboBoxBoardName.TabIndex = 23;
            // 
            // studentGroupAddCourse
            // 
            this.studentGroupAddCourse.Controls.Add(this.StudentLabelEnroll);
            this.studentGroupAddCourse.Controls.Add(this.studentGridAddCourse);
            this.studentGroupAddCourse.Location = new System.Drawing.Point(349, 773);
            this.studentGroupAddCourse.Name = "studentGroupAddCourse";
            this.studentGroupAddCourse.Size = new System.Drawing.Size(438, 189);
            this.studentGroupAddCourse.TabIndex = 29;
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
            // teacherLabelAttendance
            // 
            this.teacherLabelAttendance.Location = new System.Drawing.Point(96, 305);
            this.teacherLabelAttendance.Name = "teacherLabelAttendance";
            this.teacherLabelAttendance.Size = new System.Drawing.Size(258, 69);
            this.teacherLabelAttendance.TabIndex = 36;
            this.teacherLabelAttendance.Text = "Student Attendance";
            this.teacherLabelAttendance.UseVisualStyleBackColor = true;
            // 
            // studentGroupDropCourse
            // 
            this.studentGroupDropCourse.Controls.Add(this.studentLabelDrop);
            this.studentGroupDropCourse.Controls.Add(this.studentGridDropCourse);
            this.studentGroupDropCourse.Location = new System.Drawing.Point(647, 466);
            this.studentGroupDropCourse.Name = "studentGroupDropCourse";
            this.studentGroupDropCourse.Size = new System.Drawing.Size(315, 288);
            this.studentGroupDropCourse.TabIndex = 33;
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
            // teacherLabelStartClass
            // 
            this.teacherLabelStartClass.Location = new System.Drawing.Point(96, 215);
            this.teacherLabelStartClass.Name = "teacherLabelStartClass";
            this.teacherLabelStartClass.Size = new System.Drawing.Size(258, 69);
            this.teacherLabelStartClass.TabIndex = 35;
            this.teacherLabelStartClass.Text = "Start Class";
            this.teacherLabelStartClass.UseVisualStyleBackColor = true;
            // 
            // teacherLabelViewAttendance
            // 
            this.teacherLabelViewAttendance.Location = new System.Drawing.Point(226, 389);
            this.teacherLabelViewAttendance.Name = "teacherLabelViewAttendance";
            this.teacherLabelViewAttendance.Size = new System.Drawing.Size(159, 36);
            this.teacherLabelViewAttendance.TabIndex = 32;
            this.teacherLabelViewAttendance.Text = "View My Attendance";
            this.teacherLabelViewAttendance.UseVisualStyleBackColor = true;
            // 
            // teacherLabelEditProfile
            // 
            this.teacherLabelEditProfile.Location = new System.Drawing.Point(84, 389);
            this.teacherLabelEditProfile.Name = "teacherLabelEditProfile";
            this.teacherLabelEditProfile.Size = new System.Drawing.Size(124, 36);
            this.teacherLabelEditProfile.TabIndex = 30;
            this.teacherLabelEditProfile.Text = "Edit Profile";
            this.teacherLabelEditProfile.UseVisualStyleBackColor = true;
            // 
            // teacherPictureBox
            // 
            this.teacherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherPictureBox.Image")));
            this.teacherPictureBox.Location = new System.Drawing.Point(55, -179);
            this.teacherPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.teacherPictureBox.Name = "teacherPictureBox";
            this.teacherPictureBox.Size = new System.Drawing.Size(152, 159);
            this.teacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherPictureBox.TabIndex = 28;
            this.teacherPictureBox.TabStop = false;
            // 
            // teacherGroupSchedule
            // 
            this.teacherGroupSchedule.Controls.Add(this.teacherGridSchedule);
            this.teacherGroupSchedule.Location = new System.Drawing.Point(408, 163);
            this.teacherGroupSchedule.Name = "teacherGroupSchedule";
            this.teacherGroupSchedule.Size = new System.Drawing.Size(623, 262);
            this.teacherGroupSchedule.TabIndex = 34;
            this.teacherGroupSchedule.TabStop = false;
            this.teacherGroupSchedule.Text = "Schedule";
            // 
            // teacherGridSchedule
            // 
            this.teacherGridSchedule.AllowUserToAddRows = false;
            this.teacherGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherGridScheduleClassID,
            this.teacherGridScheduleubject,
            this.teacherGridScheduleTeacher,
            this.teacherGridScheduleTimings,
            this.teacherGridScheduleDays});
            this.teacherGridSchedule.Location = new System.Drawing.Point(18, 21);
            this.teacherGridSchedule.Name = "teacherGridSchedule";
            this.teacherGridSchedule.RowTemplate.Height = 24;
            this.teacherGridSchedule.Size = new System.Drawing.Size(582, 220);
            this.teacherGridSchedule.TabIndex = 14;
            // 
            // teacherGridScheduleClassID
            // 
            this.teacherGridScheduleClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherGridScheduleClassID.HeaderText = "ClassID";
            this.teacherGridScheduleClassID.Name = "teacherGridScheduleClassID";
            // 
            // teacherGridScheduleubject
            // 
            this.teacherGridScheduleubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherGridScheduleubject.HeaderText = "Subject";
            this.teacherGridScheduleubject.Name = "teacherGridScheduleubject";
            // 
            // teacherGridScheduleTeacher
            // 
            this.teacherGridScheduleTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherGridScheduleTeacher.HeaderText = "Teacher";
            this.teacherGridScheduleTeacher.Name = "teacherGridScheduleTeacher";
            // 
            // teacherGridScheduleTimings
            // 
            this.teacherGridScheduleTimings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherGridScheduleTimings.HeaderText = "Timings";
            this.teacherGridScheduleTimings.Name = "teacherGridScheduleTimings";
            // 
            // teacherGridScheduleDays
            // 
            this.teacherGridScheduleDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherGridScheduleDays.HeaderText = "Days";
            this.teacherGridScheduleDays.Name = "teacherGridScheduleDays";
            // 
            // teacherLabelLogOut
            // 
            this.teacherLabelLogOut.Location = new System.Drawing.Point(953, 87);
            this.teacherLabelLogOut.Name = "teacherLabelLogOut";
            this.teacherLabelLogOut.Size = new System.Drawing.Size(109, 32);
            this.teacherLabelLogOut.TabIndex = 39;
            this.teacherLabelLogOut.Text = "Log Out";
            this.teacherLabelLogOut.UseVisualStyleBackColor = true;
            this.teacherLabelLogOut.Click += new System.EventHandler(this.teacherLabelLogOut_Click);
            // 
            // teacherLabelTitle
            // 
            this.teacherLabelTitle.AutoSize = true;
            this.teacherLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.teacherLabelTitle.ForeColor = System.Drawing.Color.Teal;
            this.teacherLabelTitle.Location = new System.Drawing.Point(237, 63);
            this.teacherLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherLabelTitle.Name = "teacherLabelTitle";
            this.teacherLabelTitle.Size = new System.Drawing.Size(697, 67);
            this.teacherLabelTitle.TabIndex = 38;
            this.teacherLabelTitle.Text = "Tadrees Virtual Coaching";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 803);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 988);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.teacherLabelLogOut);
            this.Controls.Add(this.teacherLabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentGroupSearch);
            this.Controls.Add(this.studentGroupAddCourse);
            this.Controls.Add(this.teacherLabelAttendance);
            this.Controls.Add(this.studentGroupDropCourse);
            this.Controls.Add(this.teacherLabelStartClass);
            this.Controls.Add(this.teacherLabelViewAttendance);
            this.Controls.Add(this.teacherLabelEditProfile);
            this.Controls.Add(this.teacherPictureBox);
            this.Controls.Add(this.teacherGroupSchedule);
            this.Name = "TeacherForm";
            this.Text = "Tadrees Virtual Coaching";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.studentGroupSearch.ResumeLayout(false);
            this.studentGroupSearch.PerformLayout();
            this.studentGroupAddCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridAddCourse)).EndInit();
            this.studentGroupDropCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridDropCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).EndInit();
            this.teacherGroupSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StudentLabelAdd;
        private System.Windows.Forms.Label SearchClassLabelClassLevel;
        private System.Windows.Forms.ComboBox SearchClassComboBoxClassLevel;
        private System.Windows.Forms.Label SearchClassLLabelSubjects;
        private System.Windows.Forms.Label SearchClassLabelBoradName;
        private System.Windows.Forms.ComboBox SearchClassComboBoxBoardName;
        private System.Windows.Forms.GroupBox studentGroupAddCourse;
        private System.Windows.Forms.Button StudentLabelEnroll;
        private System.Windows.Forms.DataGridView studentGridAddCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGridAddColumnCourses;
        private System.Windows.Forms.Button teacherLabelAttendance;
        private System.Windows.Forms.GroupBox studentGroupDropCourse;
        private System.Windows.Forms.Button studentLabelDrop;
        private System.Windows.Forms.DataGridView studentGridDropCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGridDropColumnCourses;
        private System.Windows.Forms.Button teacherLabelStartClass;
        private System.Windows.Forms.Button teacherLabelViewAttendance;
        private System.Windows.Forms.Button teacherLabelEditProfile;
        private System.Windows.Forms.PictureBox teacherPictureBox;
        private System.Windows.Forms.GroupBox teacherGroupSchedule;
        private System.Windows.Forms.DataGridView teacherGridSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherGridScheduleClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherGridScheduleubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherGridScheduleTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherGridScheduleTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherGridScheduleDays;
        private System.Windows.Forms.Button teacherLabelLogOut;
        private System.Windows.Forms.Label teacherLabelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}