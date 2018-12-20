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
            this.studentGroupSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimingsComboBoxTime = new System.Windows.Forms.ComboBox();
            this.TimingsClassLLabelStartTime = new System.Windows.Forms.Label();
            this.studentGroupDays = new System.Windows.Forms.GroupBox();
            this.studentCheckboxDaySunday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDaySaturday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDayFriday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDayWednesday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDayThursday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDayTuesday = new System.Windows.Forms.CheckBox();
            this.studentCheckboxDayMonday = new System.Windows.Forms.CheckBox();
            this.SearchClassComboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.SearchcourseDateEndDate = new System.Windows.Forms.DateTimePicker();
            this.SearchcourseDateStartDate = new System.Windows.Forms.DateTimePicker();
            this.SearchClassLabelEndDate = new System.Windows.Forms.Label();
            this.SearchClassLabelStartDate = new System.Windows.Forms.Label();
            this.SearchcourseTextBoxCapacity = new System.Windows.Forms.TextBox();
            this.SearchClassLabelCapacity = new System.Windows.Forms.Label();
            this.StudentLabelAdd = new System.Windows.Forms.Button();
            this.SearchClassLabelClassLevel = new System.Windows.Forms.Label();
            this.SearchClassComboBoxClassLevel = new System.Windows.Forms.ComboBox();
            this.SearchClassLLabelSubjects = new System.Windows.Forms.Label();
            this.SearchClassLabelBoradName = new System.Windows.Forms.Label();
            this.SearchClassComboBoxBoardName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).BeginInit();
            this.teacherGroupSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.studentGroupSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.studentGroupDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherLabelAttendance
            // 
            this.teacherLabelAttendance.Location = new System.Drawing.Point(96, 305);
            this.teacherLabelAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherLabelAttendance.Name = "teacherLabelAttendance";
            this.teacherLabelAttendance.Size = new System.Drawing.Size(259, 69);
            this.teacherLabelAttendance.TabIndex = 36;
            this.teacherLabelAttendance.Text = "Student Attendance";
            this.teacherLabelAttendance.UseVisualStyleBackColor = true;
            // 
            // teacherLabelStartClass
            // 
            this.teacherLabelStartClass.Location = new System.Drawing.Point(96, 215);
            this.teacherLabelStartClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherLabelStartClass.Name = "teacherLabelStartClass";
            this.teacherLabelStartClass.Size = new System.Drawing.Size(259, 69);
            this.teacherLabelStartClass.TabIndex = 35;
            this.teacherLabelStartClass.Text = "Start Class";
            this.teacherLabelStartClass.UseVisualStyleBackColor = true;
            // 
            // teacherLabelViewAttendance
            // 
            this.teacherLabelViewAttendance.Location = new System.Drawing.Point(227, 389);
            this.teacherLabelViewAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherLabelViewAttendance.Name = "teacherLabelViewAttendance";
            this.teacherLabelViewAttendance.Size = new System.Drawing.Size(159, 36);
            this.teacherLabelViewAttendance.TabIndex = 32;
            this.teacherLabelViewAttendance.Text = "View My Attendance";
            this.teacherLabelViewAttendance.UseVisualStyleBackColor = true;
            // 
            // teacherLabelEditProfile
            // 
            this.teacherLabelEditProfile.Location = new System.Drawing.Point(84, 389);
            this.teacherLabelEditProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherLabelEditProfile.Name = "teacherLabelEditProfile";
            this.teacherLabelEditProfile.Size = new System.Drawing.Size(124, 36);
            this.teacherLabelEditProfile.TabIndex = 30;
            this.teacherLabelEditProfile.Text = "Edit Profile";
            this.teacherLabelEditProfile.UseVisualStyleBackColor = true;
            this.teacherLabelEditProfile.Click += new System.EventHandler(this.teacherLabelEditProfile_Click);
            // 
            // teacherPictureBox
            // 
            this.teacherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherPictureBox.Image")));
            this.teacherPictureBox.Location = new System.Drawing.Point(55, -178);
            this.teacherPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teacherPictureBox.Name = "teacherPictureBox";
            this.teacherPictureBox.Size = new System.Drawing.Size(152, 159);
            this.teacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherPictureBox.TabIndex = 28;
            this.teacherPictureBox.TabStop = false;
            // 
            // teacherGroupSchedule
            // 
            this.teacherGroupSchedule.Controls.Add(this.teacherGridSchedule);
            this.teacherGroupSchedule.Location = new System.Drawing.Point(408, 162);
            this.teacherGroupSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherGroupSchedule.Name = "teacherGroupSchedule";
            this.teacherGroupSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.teacherGridSchedule.Location = new System.Drawing.Point(19, 21);
            this.teacherGridSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherGridSchedule.Name = "teacherGridSchedule";
            this.teacherGridSchedule.RowTemplate.Height = 24;
            this.teacherGridSchedule.Size = new System.Drawing.Size(581, 220);
            this.teacherGridSchedule.TabIndex = 14;
            this.teacherGridSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGridSchedule_CellContentClick);
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
            this.teacherLabelLogOut.Location = new System.Drawing.Point(977, 95);
            this.teacherLabelLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.pictureBox1.Location = new System.Drawing.Point(84, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // studentGroupSearch
            // 
            this.studentGroupSearch.Controls.Add(this.groupBox1);
            this.studentGroupSearch.Controls.Add(this.studentGroupDays);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchcourseDateEndDate);
            this.studentGroupSearch.Controls.Add(this.SearchcourseDateStartDate);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelEndDate);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelStartDate);
            this.studentGroupSearch.Controls.Add(this.SearchcourseTextBoxCapacity);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelCapacity);
            this.studentGroupSearch.Controls.Add(this.StudentLabelAdd);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxClassLevel);
            this.studentGroupSearch.Controls.Add(this.SearchClassLLabelSubjects);
            this.studentGroupSearch.Controls.Add(this.SearchClassLabelBoradName);
            this.studentGroupSearch.Controls.Add(this.SearchClassComboBoxBoardName);
            this.studentGroupSearch.Location = new System.Drawing.Point(84, 448);
            this.studentGroupSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentGroupSearch.Name = "studentGroupSearch";
            this.studentGroupSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentGroupSearch.Size = new System.Drawing.Size(947, 401);
            this.studentGroupSearch.TabIndex = 40;
            this.studentGroupSearch.TabStop = false;
            this.studentGroupSearch.Text = "Search Course";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimingsComboBoxTime);
            this.groupBox1.Controls.Add(this.TimingsClassLLabelStartTime);
            this.groupBox1.Location = new System.Drawing.Point(542, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 81);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Timings: Class start hour (Each class of 1 hour )";
            // 
            // TimingsComboBoxTime
            // 
            this.TimingsComboBoxTime.FormattingEnabled = true;
            this.TimingsComboBoxTime.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.TimingsComboBoxTime.Location = new System.Drawing.Point(103, 38);
            this.TimingsComboBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.TimingsComboBoxTime.Name = "TimingsComboBoxTime";
            this.TimingsComboBoxTime.Size = new System.Drawing.Size(195, 24);
            this.TimingsComboBoxTime.TabIndex = 43;
            // 
            // TimingsClassLLabelStartTime
            // 
            this.TimingsClassLLabelStartTime.AutoSize = true;
            this.TimingsClassLLabelStartTime.Location = new System.Drawing.Point(18, 41);
            this.TimingsClassLLabelStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimingsClassLLabelStartTime.Name = "TimingsClassLLabelStartTime";
            this.TimingsClassLLabelStartTime.Size = new System.Drawing.Size(77, 17);
            this.TimingsClassLLabelStartTime.TabIndex = 43;
            this.TimingsClassLLabelStartTime.Text = "Start Time:";
            // 
            // studentGroupDays
            // 
            this.studentGroupDays.Controls.Add(this.studentCheckboxDaySunday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDaySaturday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDayFriday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDayWednesday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDayThursday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDayTuesday);
            this.studentGroupDays.Controls.Add(this.studentCheckboxDayMonday);
            this.studentGroupDays.Location = new System.Drawing.Point(542, 40);
            this.studentGroupDays.Name = "studentGroupDays";
            this.studentGroupDays.Size = new System.Drawing.Size(382, 153);
            this.studentGroupDays.TabIndex = 41;
            this.studentGroupDays.TabStop = false;
            this.studentGroupDays.Text = "Select Days for Classes";
            // 
            // studentCheckboxDaySunday
            // 
            this.studentCheckboxDaySunday.AutoSize = true;
            this.studentCheckboxDaySunday.Location = new System.Drawing.Point(279, 35);
            this.studentCheckboxDaySunday.Name = "studentCheckboxDaySunday";
            this.studentCheckboxDaySunday.Size = new System.Drawing.Size(78, 21);
            this.studentCheckboxDaySunday.TabIndex = 6;
            this.studentCheckboxDaySunday.Text = "Sunday";
            this.studentCheckboxDaySunday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDaySaturday
            // 
            this.studentCheckboxDaySaturday.AutoSize = true;
            this.studentCheckboxDaySaturday.Location = new System.Drawing.Point(152, 117);
            this.studentCheckboxDaySaturday.Name = "studentCheckboxDaySaturday";
            this.studentCheckboxDaySaturday.Size = new System.Drawing.Size(87, 21);
            this.studentCheckboxDaySaturday.TabIndex = 5;
            this.studentCheckboxDaySaturday.Text = "Saturday";
            this.studentCheckboxDaySaturday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDayFriday
            // 
            this.studentCheckboxDayFriday.AutoSize = true;
            this.studentCheckboxDayFriday.Location = new System.Drawing.Point(152, 76);
            this.studentCheckboxDayFriday.Name = "studentCheckboxDayFriday";
            this.studentCheckboxDayFriday.Size = new System.Drawing.Size(69, 21);
            this.studentCheckboxDayFriday.TabIndex = 4;
            this.studentCheckboxDayFriday.Text = "Friday";
            this.studentCheckboxDayFriday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDayWednesday
            // 
            this.studentCheckboxDayWednesday.AutoSize = true;
            this.studentCheckboxDayWednesday.Location = new System.Drawing.Point(21, 117);
            this.studentCheckboxDayWednesday.Name = "studentCheckboxDayWednesday";
            this.studentCheckboxDayWednesday.Size = new System.Drawing.Size(105, 21);
            this.studentCheckboxDayWednesday.TabIndex = 3;
            this.studentCheckboxDayWednesday.Text = "Wednesday";
            this.studentCheckboxDayWednesday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDayThursday
            // 
            this.studentCheckboxDayThursday.AutoSize = true;
            this.studentCheckboxDayThursday.Location = new System.Drawing.Point(152, 35);
            this.studentCheckboxDayThursday.Name = "studentCheckboxDayThursday";
            this.studentCheckboxDayThursday.Size = new System.Drawing.Size(90, 21);
            this.studentCheckboxDayThursday.TabIndex = 2;
            this.studentCheckboxDayThursday.Text = "Thursday";
            this.studentCheckboxDayThursday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDayTuesday
            // 
            this.studentCheckboxDayTuesday.AutoSize = true;
            this.studentCheckboxDayTuesday.Location = new System.Drawing.Point(21, 76);
            this.studentCheckboxDayTuesday.Name = "studentCheckboxDayTuesday";
            this.studentCheckboxDayTuesday.Size = new System.Drawing.Size(85, 21);
            this.studentCheckboxDayTuesday.TabIndex = 1;
            this.studentCheckboxDayTuesday.Text = "Tuesday";
            this.studentCheckboxDayTuesday.UseVisualStyleBackColor = true;
            // 
            // studentCheckboxDayMonday
            // 
            this.studentCheckboxDayMonday.AutoSize = true;
            this.studentCheckboxDayMonday.Location = new System.Drawing.Point(21, 35);
            this.studentCheckboxDayMonday.Name = "studentCheckboxDayMonday";
            this.studentCheckboxDayMonday.Size = new System.Drawing.Size(80, 21);
            this.studentCheckboxDayMonday.TabIndex = 0;
            this.studentCheckboxDayMonday.Text = "Monday";
            this.studentCheckboxDayMonday.UseVisualStyleBackColor = true;
            // 
            // SearchClassComboBoxSubjects
            // 
            this.SearchClassComboBoxSubjects.FormattingEnabled = true;
            this.SearchClassComboBoxSubjects.Location = new System.Drawing.Point(166, 88);
            this.SearchClassComboBoxSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxSubjects.Name = "SearchClassComboBoxSubjects";
            this.SearchClassComboBoxSubjects.Size = new System.Drawing.Size(265, 24);
            this.SearchClassComboBoxSubjects.TabIndex = 40;
            this.SearchClassComboBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.SearchClassComboBoxSubjects_SelectedIndexChanged);
            // 
            // SearchcourseDateEndDate
            // 
            this.SearchcourseDateEndDate.Location = new System.Drawing.Point(166, 322);
            this.SearchcourseDateEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.SearchcourseDateEndDate.Name = "SearchcourseDateEndDate";
            this.SearchcourseDateEndDate.Size = new System.Drawing.Size(265, 22);
            this.SearchcourseDateEndDate.TabIndex = 34;
            // 
            // SearchcourseDateStartDate
            // 
            this.SearchcourseDateStartDate.Location = new System.Drawing.Point(166, 263);
            this.SearchcourseDateStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.SearchcourseDateStartDate.Name = "SearchcourseDateStartDate";
            this.SearchcourseDateStartDate.Size = new System.Drawing.Size(265, 22);
            this.SearchcourseDateStartDate.TabIndex = 33;
            // 
            // SearchClassLabelEndDate
            // 
            this.SearchClassLabelEndDate.AutoSize = true;
            this.SearchClassLabelEndDate.Location = new System.Drawing.Point(51, 330);
            this.SearchClassLabelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelEndDate.Name = "SearchClassLabelEndDate";
            this.SearchClassLabelEndDate.Size = new System.Drawing.Size(71, 17);
            this.SearchClassLabelEndDate.TabIndex = 32;
            this.SearchClassLabelEndDate.Text = "End Date:";
            // 
            // SearchClassLabelStartDate
            // 
            this.SearchClassLabelStartDate.AutoSize = true;
            this.SearchClassLabelStartDate.Location = new System.Drawing.Point(51, 272);
            this.SearchClassLabelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelStartDate.Name = "SearchClassLabelStartDate";
            this.SearchClassLabelStartDate.Size = new System.Drawing.Size(76, 17);
            this.SearchClassLabelStartDate.TabIndex = 31;
            this.SearchClassLabelStartDate.Text = "Start Date:";
            // 
            // SearchcourseTextBoxCapacity
            // 
            this.SearchcourseTextBoxCapacity.Location = new System.Drawing.Point(166, 199);
            this.SearchcourseTextBoxCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchcourseTextBoxCapacity.Name = "SearchcourseTextBoxCapacity";
            this.SearchcourseTextBoxCapacity.Size = new System.Drawing.Size(265, 22);
            this.SearchcourseTextBoxCapacity.TabIndex = 30;
            // 
            // SearchClassLabelCapacity
            // 
            this.SearchClassLabelCapacity.AutoSize = true;
            this.SearchClassLabelCapacity.Location = new System.Drawing.Point(51, 208);
            this.SearchClassLabelCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelCapacity.Name = "SearchClassLabelCapacity";
            this.SearchClassLabelCapacity.Size = new System.Drawing.Size(66, 17);
            this.SearchClassLabelCapacity.TabIndex = 29;
            this.SearchClassLabelCapacity.Text = "Capacity:";
            // 
            // StudentLabelAdd
            // 
            this.StudentLabelAdd.Location = new System.Drawing.Point(777, 330);
            this.StudentLabelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentLabelAdd.Name = "StudentLabelAdd";
            this.StudentLabelAdd.Size = new System.Drawing.Size(147, 43);
            this.StudentLabelAdd.TabIndex = 18;
            this.StudentLabelAdd.Text = "Add Course";
            this.StudentLabelAdd.UseVisualStyleBackColor = true;
            this.StudentLabelAdd.Click += new System.EventHandler(this.StudentLabelAdd_Click);
            // 
            // SearchClassLabelClassLevel
            // 
            this.SearchClassLabelClassLevel.AutoSize = true;
            this.SearchClassLabelClassLevel.Location = new System.Drawing.Point(51, 141);
            this.SearchClassLabelClassLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelClassLevel.Name = "SearchClassLabelClassLevel";
            this.SearchClassLabelClassLevel.Size = new System.Drawing.Size(84, 17);
            this.SearchClassLabelClassLevel.TabIndex = 26;
            this.SearchClassLabelClassLevel.Text = "Class Level:";
            // 
            // SearchClassComboBoxClassLevel
            // 
            this.SearchClassComboBoxClassLevel.Location = new System.Drawing.Point(166, 141);
            this.SearchClassComboBoxClassLevel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxClassLevel.Name = "SearchClassComboBoxClassLevel";
            this.SearchClassComboBoxClassLevel.Size = new System.Drawing.Size(265, 24);
            this.SearchClassComboBoxClassLevel.TabIndex = 27;
            // 
            // SearchClassLLabelSubjects
            // 
            this.SearchClassLLabelSubjects.AutoSize = true;
            this.SearchClassLLabelSubjects.Location = new System.Drawing.Point(51, 88);
            this.SearchClassLLabelSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLLabelSubjects.Name = "SearchClassLLabelSubjects";
            this.SearchClassLLabelSubjects.Size = new System.Drawing.Size(66, 17);
            this.SearchClassLLabelSubjects.TabIndex = 24;
            this.SearchClassLLabelSubjects.Text = "Subjects:";
            // 
            // SearchClassLabelBoradName
            // 
            this.SearchClassLabelBoradName.AutoSize = true;
            this.SearchClassLabelBoradName.Location = new System.Drawing.Point(44, 40);
            this.SearchClassLabelBoradName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClassLabelBoradName.Name = "SearchClassLabelBoradName";
            this.SearchClassLabelBoradName.Size = new System.Drawing.Size(91, 17);
            this.SearchClassLabelBoradName.TabIndex = 22;
            this.SearchClassLabelBoradName.Text = "Board Name:";
            // 
            // SearchClassComboBoxBoardName
            // 
            this.SearchClassComboBoxBoardName.FormattingEnabled = true;
            this.SearchClassComboBoxBoardName.Location = new System.Drawing.Point(166, 40);
            this.SearchClassComboBoxBoardName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClassComboBoxBoardName.Name = "SearchClassComboBoxBoardName";
            this.SearchClassComboBoxBoardName.Size = new System.Drawing.Size(265, 24);
            this.SearchClassComboBoxBoardName.TabIndex = 23;
            this.SearchClassComboBoxBoardName.SelectedIndexChanged += new System.EventHandler(this.SearchClassComboBoxBoardName_SelectedIndexChanged);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 881);
            this.Controls.Add(this.studentGroupSearch);
            this.Controls.Add(this.teacherLabelLogOut);
            this.Controls.Add(this.teacherLabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teacherLabelAttendance);
            this.Controls.Add(this.teacherLabelStartClass);
            this.Controls.Add(this.teacherLabelViewAttendance);
            this.Controls.Add(this.teacherLabelEditProfile);
            this.Controls.Add(this.teacherPictureBox);
            this.Controls.Add(this.teacherGroupSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherForm";
            this.Text = "Tadrees Virtual Coaching";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherPictureBox)).EndInit();
            this.teacherGroupSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.studentGroupSearch.ResumeLayout(false);
            this.studentGroupSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.studentGroupDays.ResumeLayout(false);
            this.studentGroupDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox studentGroupSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TimingsComboBoxTime;
        private System.Windows.Forms.Label TimingsClassLLabelStartTime;
        private System.Windows.Forms.GroupBox studentGroupDays;
        private System.Windows.Forms.CheckBox studentCheckboxDaySunday;
        private System.Windows.Forms.CheckBox studentCheckboxDaySaturday;
        private System.Windows.Forms.CheckBox studentCheckboxDayFriday;
        private System.Windows.Forms.CheckBox studentCheckboxDayWednesday;
        private System.Windows.Forms.CheckBox studentCheckboxDayThursday;
        private System.Windows.Forms.CheckBox studentCheckboxDayTuesday;
        private System.Windows.Forms.CheckBox studentCheckboxDayMonday;
        private System.Windows.Forms.ComboBox SearchClassComboBoxSubjects;
        private System.Windows.Forms.DateTimePicker SearchcourseDateEndDate;
        private System.Windows.Forms.DateTimePicker SearchcourseDateStartDate;
        private System.Windows.Forms.Label SearchClassLabelEndDate;
        private System.Windows.Forms.Label SearchClassLabelStartDate;
        private System.Windows.Forms.TextBox SearchcourseTextBoxCapacity;
        private System.Windows.Forms.Label SearchClassLabelCapacity;
        private System.Windows.Forms.Button StudentLabelAdd;
        private System.Windows.Forms.Label SearchClassLabelClassLevel;
        private System.Windows.Forms.ComboBox SearchClassComboBoxClassLevel;
        private System.Windows.Forms.Label SearchClassLLabelSubjects;
        private System.Windows.Forms.Label SearchClassLabelBoradName;
        private System.Windows.Forms.ComboBox SearchClassComboBoxBoardName;
    }
}