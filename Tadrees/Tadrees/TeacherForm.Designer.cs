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
            this.SearchcourseTextBoxSubjects = new System.Windows.Forms.TextBox();
            this.StudentLabelAdd = new System.Windows.Forms.Button();
            this.SearchClassLabelClassLevel = new System.Windows.Forms.Label();
            this.SearchClassComboBoxClassLevel = new System.Windows.Forms.ComboBox();
            this.SearchClassLLabelSubjects = new System.Windows.Forms.Label();
            this.SearchClassLabelBoradName = new System.Windows.Forms.Label();
            this.SearchClassComboBoxBoardName = new System.Windows.Forms.ComboBox();
            this.teacherLabelAttendance = new System.Windows.Forms.Button();
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
            this.SearchClassLabelCapacity = new System.Windows.Forms.Label();
            this.SearchcourseTextBoxCapacity = new System.Windows.Forms.TextBox();
            this.SearchClassLabelStartDate = new System.Windows.Forms.Label();
            this.SearchClassLabelEndDate = new System.Windows.Forms.Label();
            this.SearchcourseDateStartDate = new System.Windows.Forms.DateTimePicker();
            this.SearchcourseDateEndDate = new System.Windows.Forms.DateTimePicker();
            this.studentGroupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).BeginInit();
            this.teacherGroupSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGroupSearch
            // 
            this.studentGroupSearch.Controls.Add(this.SearchcourseDateEndDate);
            this.studentGroupSearch.Controls.Add(this.SearchcourseDateStartDate);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelEndDate);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelStartDate);
            this.studentGroupSearch.Controls.Add(this.SearchcourseTextBoxCapacity);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelCapacity);
            this.studentGroupSearch.Controls.Add(this.SearchcourseTextBoxSubjects);
            this.studentGroupSearch.Controls.Add(this.StudentLabelAdd);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassLLabelSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelBoradName);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxBoardName);
            this.studentGroupSearch.Location = new System.Drawing.Point(89, 379);
            this.studentGroupSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentGroupSearch.Name = "studentGroupSearch";
            this.studentGroupSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentGroupSearch.Size = new System.Drawing.Size(370, 326);
            this.studentGroupSearch.TabIndex = 31;
            this.studentGroupSearch.TabStop = false;
            this.studentGroupSearch.Text = "Search Course";
            // 
            // SearchcourseTextBoxSubjects
            // 
            this.SearchcourseTextBoxSubjects.Location = new System.Drawing.Point(131, 71);
            this.SearchcourseTextBoxSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchcourseTextBoxSubjects.Name = "SearchcourseTextBoxSubjects";
            this.SearchcourseTextBoxSubjects.Size = new System.Drawing.Size(200, 20);
            this.SearchcourseTextBoxSubjects.TabIndex = 28;
            this.SearchcourseTextBoxSubjects.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentLabelAdd
            // 
            this.StudentLabelAdd.Location = new System.Drawing.Point(257, 297);
            this.StudentLabelAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentLabelAdd.Name = "StudentLabelAdd";
            this.StudentLabelAdd.Size = new System.Drawing.Size(97, 25);
            this.StudentLabelAdd.TabIndex = 18;
            this.StudentLabelAdd.Text = "Add Course";
            this.StudentLabelAdd.UseVisualStyleBackColor = true;
            // 
            // SearchClassLabelClassLevel
            // 
            this.SearchClassLabelClassLevel.AutoSize = true;
            this.SearchClassLabelClassLevel.Location = new System.Drawing.Point(45, 114);
            this.SearchClassLabelClassLevel.Name = "SearchClassLabelClassLevel";
            this.SearchClassLabelClassLevel.Size = new System.Drawing.Size(64, 13);
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
            this.SearchClassComboBoxClassLevel.Location = new System.Drawing.Point(131, 114);
            this.SearchClassComboBoxClassLevel.Name = "SearchClassComboBoxClassLevel";
            this.SearchClassComboBoxClassLevel.Size = new System.Drawing.Size(200, 21);
            this.SearchClassComboBoxClassLevel.TabIndex = 27;
            // 
            // SearchClassLLabelSubjects
            // 
            this.SearchClassLLabelSubjects.AutoSize = true;
            this.SearchClassLLabelSubjects.Location = new System.Drawing.Point(45, 71);
            this.SearchClassLLabelSubjects.Name = "SearchClassLLabelSubjects";
            this.SearchClassLLabelSubjects.Size = new System.Drawing.Size(51, 13);
            this.SearchClassLLabelSubjects.TabIndex = 24;
            this.SearchClassLLabelSubjects.Text = "Subjects:";
            this.SearchClassLLabelSubjects.Click += new System.EventHandler(this.SearchClassLLabelSubjects_Click);
            // 
            // SearchClassLabelBoradName
            // 
            this.SearchClassLabelBoradName.AutoSize = true;
            this.SearchClassLabelBoradName.Location = new System.Drawing.Point(40, 32);
            this.SearchClassLabelBoradName.Name = "SearchClassLabelBoradName";
            this.SearchClassLabelBoradName.Size = new System.Drawing.Size(69, 13);
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
            this.SearchClassComboBoxBoardName.Location = new System.Drawing.Point(131, 32);
            this.SearchClassComboBoxBoardName.Name = "SearchClassComboBoxBoardName";
            this.SearchClassComboBoxBoardName.Size = new System.Drawing.Size(200, 21);
            this.SearchClassComboBoxBoardName.TabIndex = 23;
            // 
            // teacherLabelAttendance
            // 
            this.teacherLabelAttendance.Location = new System.Drawing.Point(72, 248);
            this.teacherLabelAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherLabelAttendance.Name = "teacherLabelAttendance";
            this.teacherLabelAttendance.Size = new System.Drawing.Size(194, 56);
            this.teacherLabelAttendance.TabIndex = 36;
            this.teacherLabelAttendance.Text = "Student Attendance";
            this.teacherLabelAttendance.UseVisualStyleBackColor = true;
            // 
            // teacherLabelStartClass
            // 
            this.teacherLabelStartClass.Location = new System.Drawing.Point(72, 175);
            this.teacherLabelStartClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherLabelStartClass.Name = "teacherLabelStartClass";
            this.teacherLabelStartClass.Size = new System.Drawing.Size(194, 56);
            this.teacherLabelStartClass.TabIndex = 35;
            this.teacherLabelStartClass.Text = "Start Class";
            this.teacherLabelStartClass.UseVisualStyleBackColor = true;
            // 
            // teacherLabelViewAttendance
            // 
            this.teacherLabelViewAttendance.Location = new System.Drawing.Point(170, 316);
            this.teacherLabelViewAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherLabelViewAttendance.Name = "teacherLabelViewAttendance";
            this.teacherLabelViewAttendance.Size = new System.Drawing.Size(119, 29);
            this.teacherLabelViewAttendance.TabIndex = 32;
            this.teacherLabelViewAttendance.Text = "View My Attendance";
            this.teacherLabelViewAttendance.UseVisualStyleBackColor = true;
            // 
            // teacherLabelEditProfile
            // 
            this.teacherLabelEditProfile.Location = new System.Drawing.Point(63, 316);
            this.teacherLabelEditProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherLabelEditProfile.Name = "teacherLabelEditProfile";
            this.teacherLabelEditProfile.Size = new System.Drawing.Size(93, 29);
            this.teacherLabelEditProfile.TabIndex = 30;
            this.teacherLabelEditProfile.Text = "Edit Profile";
            this.teacherLabelEditProfile.UseVisualStyleBackColor = true;
            // 
            // teacherPictureBox
            // 
            this.teacherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherPictureBox.Image")));
            this.teacherPictureBox.Location = new System.Drawing.Point(41, -145);
            this.teacherPictureBox.Name = "teacherPictureBox";
            this.teacherPictureBox.Size = new System.Drawing.Size(114, 129);
            this.teacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherPictureBox.TabIndex = 28;
            this.teacherPictureBox.TabStop = false;
            // 
            // teacherGroupSchedule
            // 
            this.teacherGroupSchedule.Controls.Add(this.teacherGridSchedule);
            this.teacherGroupSchedule.Location = new System.Drawing.Point(306, 132);
            this.teacherGroupSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherGroupSchedule.Name = "teacherGroupSchedule";
            this.teacherGroupSchedule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherGroupSchedule.Size = new System.Drawing.Size(467, 213);
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
            this.teacherGridSchedule.Location = new System.Drawing.Point(14, 17);
            this.teacherGridSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherGridSchedule.Name = "teacherGridSchedule";
            this.teacherGridSchedule.RowTemplate.Height = 24;
            this.teacherGridSchedule.Size = new System.Drawing.Size(436, 179);
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
            this.teacherLabelLogOut.Location = new System.Drawing.Point(733, 77);
            this.teacherLabelLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherLabelLogOut.Name = "teacherLabelLogOut";
            this.teacherLabelLogOut.Size = new System.Drawing.Size(82, 26);
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
            this.teacherLabelTitle.Location = new System.Drawing.Point(178, 51);
            this.teacherLabelTitle.Name = "teacherLabelTitle";
            this.teacherLabelTitle.Size = new System.Drawing.Size(550, 54);
            this.teacherLabelTitle.TabIndex = 38;
            this.teacherLabelTitle.Text = "Tadrees Virtual Coaching";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SearchClassLabelCapacity
            // 
            this.SearchClassLabelCapacity.AutoSize = true;
            this.SearchClassLabelCapacity.Location = new System.Drawing.Point(45, 168);
            this.SearchClassLabelCapacity.Name = "SearchClassLabelCapacity";
            this.SearchClassLabelCapacity.Size = new System.Drawing.Size(51, 13);
            this.SearchClassLabelCapacity.TabIndex = 29;
            this.SearchClassLabelCapacity.Text = "Capacity:";
            this.SearchClassLabelCapacity.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchcourseTextBoxCapacity
            // 
            this.SearchcourseTextBoxCapacity.Location = new System.Drawing.Point(131, 161);
            this.SearchcourseTextBoxCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.SearchcourseTextBoxCapacity.Name = "SearchcourseTextBoxCapacity";
            this.SearchcourseTextBoxCapacity.Size = new System.Drawing.Size(200, 20);
            this.SearchcourseTextBoxCapacity.TabIndex = 30;
            // 
            // SearchClassLabelStartDate
            // 
            this.SearchClassLabelStartDate.AutoSize = true;
            this.SearchClassLabelStartDate.Location = new System.Drawing.Point(45, 220);
            this.SearchClassLabelStartDate.Name = "SearchClassLabelStartDate";
            this.SearchClassLabelStartDate.Size = new System.Drawing.Size(58, 13);
            this.SearchClassLabelStartDate.TabIndex = 31;
            this.SearchClassLabelStartDate.Text = "Start Date:";
            // 
            // SearchClassLabelEndDate
            // 
            this.SearchClassLabelEndDate.AutoSize = true;
            this.SearchClassLabelEndDate.Location = new System.Drawing.Point(45, 267);
            this.SearchClassLabelEndDate.Name = "SearchClassLabelEndDate";
            this.SearchClassLabelEndDate.Size = new System.Drawing.Size(55, 13);
            this.SearchClassLabelEndDate.TabIndex = 32;
            this.SearchClassLabelEndDate.Text = "End Date:";
            // 
            // SearchcourseDateStartDate
            // 
            this.SearchcourseDateStartDate.Location = new System.Drawing.Point(131, 213);
            this.SearchcourseDateStartDate.Name = "SearchcourseDateStartDate";
            this.SearchcourseDateStartDate.Size = new System.Drawing.Size(200, 20);
            this.SearchcourseDateStartDate.TabIndex = 33;
            // 
            // SearchcourseDateEndDate
            // 
            this.SearchcourseDateEndDate.Location = new System.Drawing.Point(131, 261);
            this.SearchcourseDateEndDate.Name = "SearchcourseDateEndDate";
            this.SearchcourseDateEndDate.Size = new System.Drawing.Size(200, 20);
            this.SearchcourseDateEndDate.TabIndex = 34;
            this.SearchcourseDateEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 716);
            this.Controls.Add(this.teacherLabelLogOut);
            this.Controls.Add(this.teacherLabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentGroupSearch);
            this.Controls.Add(this.teacherLabelAttendance);
            this.Controls.Add(this.teacherLabelStartClass);
            this.Controls.Add(this.teacherLabelViewAttendance);
            this.Controls.Add(this.teacherLabelEditProfile);
            this.Controls.Add(this.teacherPictureBox);
            this.Controls.Add(this.teacherGroupSchedule);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherForm";
            this.Text = "Tadrees Virtual Coaching";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.studentGroupSearch.ResumeLayout(false);
            this.studentGroupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).EndInit();
            this.teacherGroupSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupSearch;
        private System.Windows.Forms.TextBox SearchcourseTextBoxSubjects;
        private System.Windows.Forms.Button StudentLabelAdd;
        private System.Windows.Forms.Label SearchClassLabelClassLevel;
        private System.Windows.Forms.ComboBox SearchClassComboBoxClassLevel;
        private System.Windows.Forms.Label SearchClassLLabelSubjects;
        private System.Windows.Forms.Label SearchClassLabelBoradName;
        private System.Windows.Forms.ComboBox SearchClassComboBoxBoardName;
        private System.Windows.Forms.Button teacherLabelAttendance;
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
        private System.Windows.Forms.Label SearchClassLabelCapacity;
        private System.Windows.Forms.Label SearchClassLabelStartDate;
        private System.Windows.Forms.TextBox SearchcourseTextBoxCapacity;
        private System.Windows.Forms.Label SearchClassLabelEndDate;
        private System.Windows.Forms.DateTimePicker SearchcourseDateEndDate;
        private System.Windows.Forms.DateTimePicker SearchcourseDateStartDate;
    }
}