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
            connection.ConnectionString = "server = localhost\\sqlexpress; database = Coaching; integrated security = True;";
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
            this.Hide();
            Form form = new TeacherForm(connection);
            form.Show();
            form.FormClosed += (s, args) => this.Show();
        }

        private void SignUpStudentButtonSignUp_Click(object sender, EventArgs e)
        {
            if(SignUpTextBoxFirstName.Text != "" && SignUpTextBoxLastName.Text != "" && SignUpTextBoxPassword.Text != "" && SignUpTextBoxEmail.Text != "")
            {
                if(SignupStudentComboBox.Text == "Student")
                {
                    SqlCommand command = new SqlCommand("Insert Into Student(FirstName, LastName,Email,Password) values('"+
                        SignUpTextBoxFirstName.Text + "\',\'" + SignUpTextBoxLastName.Text +"\',\'"+ SignUpTextBoxEmail.Text +"\',\'"+ SignUpTextBoxPassword.Text
                        + "\')");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Please Enter All The Fields", "Error Signing Up");
            }
        }
    }
}
