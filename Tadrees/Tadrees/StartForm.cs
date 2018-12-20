using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tadrees
{
    public partial class StartForm : Form
    {
        SqlConnection connection; //This is the main attribute which will be passed in every form
        public StartForm()
        {
            InitializeComponent();
            /**** Initialization of SQL Connection  ****/
            connection = new SqlConnection();
            connection.ConnectionString = "server = localhost\\sqlexpress; database = Project; integrated security = True;";
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            string id;
            SqlCommand command;
            if(LoginComboBox.Text == "Student")
            {
                command = new SqlCommand("Select StudentID,Password from Student", connection);
                id = "StudentID";
            }
            else
            {
                command = new SqlCommand("Select TeacherID,Password from Teacher", connection);
                id = "TeacherID";
            }
            SqlDataReader dataReader = command.ExecuteReader();
            bool login = false;
            while (dataReader.Read())
            {
                if (dataReader[id].ToString() == LoginTextBoxId.Text && dataReader["Password"].ToString() == LoginTextBoxPassword.Text)
                {
                    login = true;
                    break;
                }
            }
            dataReader.Close();
            if (login == true)
            {
                id = LoginTextBoxId.Text;
                LoginTextBoxId.Text = "";
                LoginTextBoxPassword.Text = "";
                if(LoginComboBox.Text == "Teacher")
                {
                    this.Hide();
                    Form form = new TeacherForm(connection, id);
                    form.Show();
                    form.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    this.Hide();
                    Form form = new StudentForm(connection, id);
                    form.Show();
                    form.FormClosed += (s, args) => this.Show();
                }
            }
            else
            {
                MessageBox.Show("Your Id Or Password Is Wrong Or You are not Registered", "Error Logging In");
            }
            
        }
        /*** The Signup Work To be done in two Buttons ***/
        private bool SignupHelper(string FirstName, string LastName, string Email, string Password)
        {
            bool result = false;
            /*** IF All The Textboxes are Filled ***/
            if (FirstName == "" || LastName == "" || Password == "" || Email == "")
            {
                MessageBox.Show("Please Enter All The Fields.", "Error Signing Up");
            }
            else if (FirstName.Any(char.IsDigit) || LastName.Any(char.IsDigit)) //Only Add Alphabets In Name
            {
                MessageBox.Show("Name does not accept digit.", "Error Signing Up");
            }
            else if (Password.Length < 6) //Passwords must be more than 6
            {
                MessageBox.Show("Passwords must be at least 6 characters long.", "Error Signing Up");
            }
            else
            {
                result = true;
            }
            return result;
        }
        private void SignUpStudentButtonSignUp_Click(object sender, EventArgs e)
        {
            string firstName = SignUpTextBoxFirstName.Text;
            string lastName = SignUpTextBoxLastName.Text;
            string email = SignUpTextBoxEmail.Text;
            string password = SignUpTextBoxPassword.Text;
            string query = "select Count(*) from Student";
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar() + 1;
            if (SignupHelper(firstName, lastName, email, password))
            {
                string id = firstName[0].ToString().ToLower() + lastName[0].ToString().ToLower() + count.ToString();
                SqlCommand command = new SqlCommand("Insert Into Student(StudentID, FirstName, LastName,Email,Password,DateJoined) values('"+
                    id + "\',\'" + firstName + "\',\'" + lastName +"\',\'"+ email +"\',\'"+ password + "\',GetDate())");
                command.Connection = connection;
                command.ExecuteNonQuery();
                SignUpTextBoxFirstName.Text = "";
                SignUpTextBoxLastName.Text = "";
                SignUpTextBoxEmail.Text = "";
                SignUpTextBoxPassword.Text = "";
                this.Hide();
                Form form = new StudentForm(connection, id);
                form.Show();
                form.FormClosed += (s, args) => this.Show();
            }
        }

        private void SignUpTextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignUpTextBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignupStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SignupStudentComboBox.Text == "Teacher")
            {
                Qualification.Visible = true;
                SignUpStudentButtonSignUp.Visible = false;
            }
            else
            {
                Qualification.Visible = false;
                SignUpStudentButtonSignUp.Visible = true;
            }
        }

        private void QualificationButtonSignUp_Click(object sender, EventArgs e)
        {
            string firstName = SignUpTextBoxFirstName.Text;
            string lastName = SignUpTextBoxLastName.Text;
            string email = SignUpTextBoxEmail.Text;
            string password = SignUpTextBoxPassword.Text;
            string query = "select Count(*) from Teacher";
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar() + 1;
            if (SignupHelper(firstName, lastName, email, password))
            {
                string id = firstName[0].ToString().ToLower() + lastName[0].ToString().ToLower() + "t" + count.ToString();
                query = "Insert into Teacher(TeacherID, FirstName, LastName, Email, Password, DateJoined) values('"
                    + id + "' , '" + firstName + "' , '" + lastName + "' , '" + email + "' , '" + password + "' , " + "GetDate())";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                if(Degree.Text != "" && Qualification.Text != "")
                {
                    query = "Insert into Qualification(Degree, Year, University, TeacherID) values('" +
                                        Degree.Text + "' , '" + Year.Text + "' , '" + University.Text + "' , '" + id + "')";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                SignUpTextBoxFirstName.Text = "";
                SignUpTextBoxLastName.Text = "";
                SignUpTextBoxEmail.Text = "";
                SignUpTextBoxPassword.Text = "";
                Qualification.Text = "";
                Degree.Text = "";
                Year.Text = "";
                this.Hide();
                Form form = new TeacherForm(connection, id);
                form.Show();
                form.FormClosed += (s, args) => this.Show();
            }
        }

        private void LoginTextBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
