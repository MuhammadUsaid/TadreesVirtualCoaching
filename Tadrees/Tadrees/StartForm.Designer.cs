namespace Tadrees
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StudentSearchClassLabelTitle = new System.Windows.Forms.Label();
            this.StudentSearchClassPictureBox = new System.Windows.Forms.PictureBox();
            this.SignUp = new System.Windows.Forms.GroupBox();
            this.Qualification = new System.Windows.Forms.GroupBox();
            this.QualificationButtonSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.University = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SignupStudentLabelFirstName = new System.Windows.Forms.Label();
            this.SignupStudentComboBox = new System.Windows.Forms.ComboBox();
            this.SignUpTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.SignUpStudentButtonSignUp = new System.Windows.Forms.Button();
            this.SignUpTextBoxLastName = new System.Windows.Forms.TextBox();
            this.SignupStudentLabelPassword = new System.Windows.Forms.Label();
            this.SignUpTextBoxEmail = new System.Windows.Forms.TextBox();
            this.SignupStudentLabelEmail = new System.Windows.Forms.Label();
            this.SignUpTextBoxPassword = new System.Windows.Forms.TextBox();
            this.SignupStudentLabelLastName = new System.Windows.Forms.Label();
            this.LoginForm = new System.Windows.Forms.GroupBox();
            this.LoginComboBox = new System.Windows.Forms.ComboBox();
            this.LoginButtonLogin = new System.Windows.Forms.Button();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginLabelId = new System.Windows.Forms.Label();
            this.LoginTextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginTextBoxId = new System.Windows.Forms.TextBox();
            this.Degree = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSearchClassPictureBox)).BeginInit();
            this.SignUp.SuspendLayout();
            this.Qualification.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentSearchClassLabelTitle
            // 
            this.StudentSearchClassLabelTitle.AutoSize = true;
            this.StudentSearchClassLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.StudentSearchClassLabelTitle.ForeColor = System.Drawing.Color.Teal;
            this.StudentSearchClassLabelTitle.Location = new System.Drawing.Point(180, 27);
            this.StudentSearchClassLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentSearchClassLabelTitle.Name = "StudentSearchClassLabelTitle";
            this.StudentSearchClassLabelTitle.Size = new System.Drawing.Size(697, 67);
            this.StudentSearchClassLabelTitle.TabIndex = 14;
            this.StudentSearchClassLabelTitle.Text = "Tadrees Virtual Coaching";
            // 
            // StudentSearchClassPictureBox
            // 
            this.StudentSearchClassPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StudentSearchClassPictureBox.Image")));
            this.StudentSearchClassPictureBox.Location = new System.Drawing.Point(50, 13);
            this.StudentSearchClassPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentSearchClassPictureBox.Name = "StudentSearchClassPictureBox";
            this.StudentSearchClassPictureBox.Size = new System.Drawing.Size(100, 92);
            this.StudentSearchClassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentSearchClassPictureBox.TabIndex = 13;
            this.StudentSearchClassPictureBox.TabStop = false;
            // 
            // SignUp
            // 
            this.SignUp.Controls.Add(this.Qualification);
            this.SignUp.Controls.Add(this.groupBox1);
            this.SignUp.Location = new System.Drawing.Point(43, 200);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(870, 331);
            this.SignUp.TabIndex = 12;
            this.SignUp.TabStop = false;
            this.SignUp.Text = "Signup";
            // 
            // Qualification
            // 
            this.Qualification.Controls.Add(this.QualificationButtonSignUp);
            this.Qualification.Controls.Add(this.panel1);
            this.Qualification.Location = new System.Drawing.Point(492, 46);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(351, 285);
            this.Qualification.TabIndex = 15;
            this.Qualification.TabStop = false;
            this.Qualification.Text = "Qualification";
            this.Qualification.Visible = false;
            // 
            // QualificationButtonSignUp
            // 
            this.QualificationButtonSignUp.Location = new System.Drawing.Point(248, 240);
            this.QualificationButtonSignUp.Name = "QualificationButtonSignUp";
            this.QualificationButtonSignUp.Size = new System.Drawing.Size(75, 29);
            this.QualificationButtonSignUp.TabIndex = 6;
            this.QualificationButtonSignUp.Text = "Sign Up";
            this.QualificationButtonSignUp.UseVisualStyleBackColor = true;
            this.QualificationButtonSignUp.Click += new System.EventHandler(this.QualificationButtonSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Degree);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.University);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 201);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degree:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "University:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // University
            // 
            this.University.Location = new System.Drawing.Point(101, 55);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(176, 22);
            this.University.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SignupStudentLabelFirstName);
            this.groupBox1.Controls.Add(this.SignupStudentComboBox);
            this.groupBox1.Controls.Add(this.SignUpTextBoxFirstName);
            this.groupBox1.Controls.Add(this.SignUpStudentButtonSignUp);
            this.groupBox1.Controls.Add(this.SignUpTextBoxLastName);
            this.groupBox1.Controls.Add(this.SignupStudentLabelPassword);
            this.groupBox1.Controls.Add(this.SignUpTextBoxEmail);
            this.groupBox1.Controls.Add(this.SignupStudentLabelEmail);
            this.groupBox1.Controls.Add(this.SignUpTextBoxPassword);
            this.groupBox1.Controls.Add(this.SignupStudentLabelLastName);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 265);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // SignupStudentLabelFirstName
            // 
            this.SignupStudentLabelFirstName.AutoSize = true;
            this.SignupStudentLabelFirstName.Location = new System.Drawing.Point(6, 34);
            this.SignupStudentLabelFirstName.Name = "SignupStudentLabelFirstName";
            this.SignupStudentLabelFirstName.Size = new System.Drawing.Size(80, 17);
            this.SignupStudentLabelFirstName.TabIndex = 4;
            this.SignupStudentLabelFirstName.Text = "First Name:";
            // 
            // SignupStudentComboBox
            // 
            this.SignupStudentComboBox.FormattingEnabled = true;
            this.SignupStudentComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.SignupStudentComboBox.Location = new System.Drawing.Point(167, 214);
            this.SignupStudentComboBox.Name = "SignupStudentComboBox";
            this.SignupStudentComboBox.Size = new System.Drawing.Size(113, 24);
            this.SignupStudentComboBox.TabIndex = 10;
            this.SignupStudentComboBox.Text = "Student";
            this.SignupStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.SignupStudentComboBox_SelectedIndexChanged);
            // 
            // SignUpTextBoxFirstName
            // 
            this.SignUpTextBoxFirstName.Location = new System.Drawing.Point(167, 35);
            this.SignUpTextBoxFirstName.Name = "SignUpTextBoxFirstName";
            this.SignUpTextBoxFirstName.Size = new System.Drawing.Size(194, 22);
            this.SignUpTextBoxFirstName.TabIndex = 1;
            this.SignUpTextBoxFirstName.TextChanged += new System.EventHandler(this.SignUpTextBoxFirstName_TextChanged);
            // 
            // SignUpStudentButtonSignUp
            // 
            this.SignUpStudentButtonSignUp.Location = new System.Drawing.Point(286, 209);
            this.SignUpStudentButtonSignUp.Name = "SignUpStudentButtonSignUp";
            this.SignUpStudentButtonSignUp.Size = new System.Drawing.Size(75, 33);
            this.SignUpStudentButtonSignUp.TabIndex = 9;
            this.SignUpStudentButtonSignUp.Text = "Sign Up";
            this.SignUpStudentButtonSignUp.UseVisualStyleBackColor = true;
            this.SignUpStudentButtonSignUp.Click += new System.EventHandler(this.SignUpStudentButtonSignUp_Click);
            // 
            // SignUpTextBoxLastName
            // 
            this.SignUpTextBoxLastName.Location = new System.Drawing.Point(167, 73);
            this.SignUpTextBoxLastName.Name = "SignUpTextBoxLastName";
            this.SignUpTextBoxLastName.Size = new System.Drawing.Size(194, 22);
            this.SignUpTextBoxLastName.TabIndex = 2;
            // 
            // SignupStudentLabelPassword
            // 
            this.SignupStudentLabelPassword.AutoSize = true;
            this.SignupStudentLabelPassword.Location = new System.Drawing.Point(6, 172);
            this.SignupStudentLabelPassword.Name = "SignupStudentLabelPassword";
            this.SignupStudentLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.SignupStudentLabelPassword.TabIndex = 8;
            this.SignupStudentLabelPassword.Text = "Password:";
            // 
            // SignUpTextBoxEmail
            // 
            this.SignUpTextBoxEmail.Location = new System.Drawing.Point(167, 119);
            this.SignUpTextBoxEmail.Name = "SignUpTextBoxEmail";
            this.SignUpTextBoxEmail.Size = new System.Drawing.Size(194, 22);
            this.SignUpTextBoxEmail.TabIndex = 3;
            // 
            // SignupStudentLabelEmail
            // 
            this.SignupStudentLabelEmail.AutoSize = true;
            this.SignupStudentLabelEmail.Location = new System.Drawing.Point(6, 124);
            this.SignupStudentLabelEmail.Name = "SignupStudentLabelEmail";
            this.SignupStudentLabelEmail.Size = new System.Drawing.Size(46, 17);
            this.SignupStudentLabelEmail.TabIndex = 7;
            this.SignupStudentLabelEmail.Text = "Email:";
            // 
            // SignUpTextBoxPassword
            // 
            this.SignUpTextBoxPassword.Location = new System.Drawing.Point(167, 167);
            this.SignUpTextBoxPassword.Name = "SignUpTextBoxPassword";
            this.SignUpTextBoxPassword.PasswordChar = '*';
            this.SignUpTextBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.SignUpTextBoxPassword.TabIndex = 4;
            this.SignUpTextBoxPassword.TextChanged += new System.EventHandler(this.SignUpTextBoxPassword_TextChanged);
            // 
            // SignupStudentLabelLastName
            // 
            this.SignupStudentLabelLastName.AutoSize = true;
            this.SignupStudentLabelLastName.Location = new System.Drawing.Point(6, 78);
            this.SignupStudentLabelLastName.Name = "SignupStudentLabelLastName";
            this.SignupStudentLabelLastName.Size = new System.Drawing.Size(80, 17);
            this.SignupStudentLabelLastName.TabIndex = 3;
            this.SignupStudentLabelLastName.Text = "Last Name:";
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.LoginComboBox);
            this.LoginForm.Controls.Add(this.LoginButtonLogin);
            this.LoginForm.Controls.Add(this.LoginLabelPassword);
            this.LoginForm.Controls.Add(this.LoginLabelId);
            this.LoginForm.Controls.Add(this.LoginTextBoxPassword);
            this.LoginForm.Controls.Add(this.LoginTextBoxId);
            this.LoginForm.Location = new System.Drawing.Point(43, 108);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(855, 69);
            this.LoginForm.TabIndex = 11;
            this.LoginForm.TabStop = false;
            this.LoginForm.Text = "LogIn";
            // 
            // LoginComboBox
            // 
            this.LoginComboBox.FormattingEnabled = true;
            this.LoginComboBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.LoginComboBox.Location = new System.Drawing.Point(528, 26);
            this.LoginComboBox.Name = "LoginComboBox";
            this.LoginComboBox.Size = new System.Drawing.Size(121, 24);
            this.LoginComboBox.TabIndex = 2;
            this.LoginComboBox.Text = "Student";
            // 
            // LoginButtonLogin
            // 
            this.LoginButtonLogin.Location = new System.Drawing.Point(676, 26);
            this.LoginButtonLogin.Name = "LoginButtonLogin";
            this.LoginButtonLogin.Size = new System.Drawing.Size(75, 25);
            this.LoginButtonLogin.TabIndex = 3;
            this.LoginButtonLogin.Text = "Login";
            this.LoginButtonLogin.UseVisualStyleBackColor = true;
            this.LoginButtonLogin.Click += new System.EventHandler(this.LoginButtonLogin_Click);
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.Location = new System.Drawing.Point(245, 26);
            this.LoginLabelPassword.Name = "LoginLabelPassword";
            this.LoginLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.LoginLabelPassword.TabIndex = 2;
            this.LoginLabelPassword.Text = "Password:";
            // 
            // LoginLabelId
            // 
            this.LoginLabelId.AutoSize = true;
            this.LoginLabelId.Location = new System.Drawing.Point(16, 29);
            this.LoginLabelId.Name = "LoginLabelId";
            this.LoginLabelId.Size = new System.Drawing.Size(25, 17);
            this.LoginLabelId.TabIndex = 2;
            this.LoginLabelId.Text = "ID:";
            // 
            // LoginTextBoxPassword
            // 
            this.LoginTextBoxPassword.Location = new System.Drawing.Point(324, 26);
            this.LoginTextBoxPassword.Name = "LoginTextBoxPassword";
            this.LoginTextBoxPassword.PasswordChar = '*';
            this.LoginTextBoxPassword.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxPassword.TabIndex = 1;
            this.LoginTextBoxPassword.UseWaitCursor = true;
            // 
            // LoginTextBoxId
            // 
            this.LoginTextBoxId.Location = new System.Drawing.Point(47, 26);
            this.LoginTextBoxId.Name = "LoginTextBoxId";
            this.LoginTextBoxId.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxId.TabIndex = 0;
            this.LoginTextBoxId.UseWaitCursor = true;
            this.LoginTextBoxId.TextChanged += new System.EventHandler(this.LoginTextBoxId_TextChanged);
            // 
            // Degree
            // 
            this.Degree.Items.AddRange(new object[] {
            "Bachelors",
            "Masters",
            "PhD"});
            this.Degree.Location = new System.Drawing.Point(101, 19);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(176, 24);
            this.Degree.TabIndex = 0;
            this.Degree.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.Year.Location = new System.Drawing.Point(101, 101);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(176, 24);
            this.Year.TabIndex = 5;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.StudentSearchClassLabelTitle);
            this.Controls.Add(this.StudentSearchClassPictureBox);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LoginForm);
            this.Name = "StartForm";
            this.Text = "Tadrees Virtual Coaching";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentSearchClassPictureBox)).EndInit();
            this.SignUp.ResumeLayout(false);
            this.Qualification.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentSearchClassLabelTitle;
        private System.Windows.Forms.PictureBox StudentSearchClassPictureBox;
        private System.Windows.Forms.GroupBox SignUp;
        private System.Windows.Forms.ComboBox SignupStudentComboBox;
        private System.Windows.Forms.Button SignUpStudentButtonSignUp;
        private System.Windows.Forms.Label SignupStudentLabelPassword;
        private System.Windows.Forms.Label SignupStudentLabelEmail;
        private System.Windows.Forms.Label SignupStudentLabelLastName;
        private System.Windows.Forms.Label SignupStudentLabelFirstName;
        private System.Windows.Forms.TextBox SignUpTextBoxPassword;
        private System.Windows.Forms.TextBox SignUpTextBoxEmail;
        private System.Windows.Forms.TextBox SignUpTextBoxLastName;
        private System.Windows.Forms.TextBox SignUpTextBoxFirstName;
        private System.Windows.Forms.GroupBox LoginForm;
        private System.Windows.Forms.ComboBox LoginComboBox;
        private System.Windows.Forms.Button LoginButtonLogin;
        private System.Windows.Forms.Label LoginLabelPassword;
        private System.Windows.Forms.Label LoginLabelId;
        private System.Windows.Forms.TextBox LoginTextBoxPassword;
        private System.Windows.Forms.TextBox LoginTextBoxId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Qualification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QualificationButtonSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox University;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Degree;
        private System.Windows.Forms.ComboBox Year;
    }
}

