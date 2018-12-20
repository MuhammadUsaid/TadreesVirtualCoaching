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
    public partial class StudentForm : Form
    {
        SqlConnection connection;
        string userID;
        public StudentForm(SqlConnection con, string id)
        {
            InitializeComponent();
            connection = con;
            userID = id;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select BoardName from Board");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader rd = command.ExecuteReader();
            SearchClassComboBoxBoardName.Items.Clear();
            while (rd.Read())
            {
                SearchClassComboBoxBoardName.Items.Add(rd["BoardName"]);
            }
            rd.Close();
        }

        private void SearchClassComboBoxBoardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select distinct(subjectName) from subject,Board where Subject.BoardID = Board.ID and BoardName = '" + (SearchClassComboBoxBoardName.SelectedItem.ToString()) + "'");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader rd = command.ExecuteReader();
            SearchClassComboBoxSubjects.Items.Clear();
            while (rd.Read())
            {
                SearchClassComboBoxSubjects.Items.Add(rd["SubjectName"]);
            }
            rd.Close();
        }

        private void SearchClassComboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select distinct(ClassLevel) from Subject,ClassLevel,Board where Subject.ClassLevelID = ClassLevel.ID and SubjectName = '" + (SearchClassComboBoxSubjects.SelectedItem.ToString()) + "' and BoardName = '" + (SearchClassComboBoxBoardName.SelectedItem.ToString()) + "'");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader rd = command.ExecuteReader();
            SearchClassComboBoxClassLevel.Items.Clear();
            while (rd.Read())
            {
                SearchClassComboBoxClassLevel.Items.Add(rd["ClassLevel"]);
            }
            rd.Close();
        }

        private void StudentLabelAdd_Click(object sender, EventArgs e)
        {
            if (SearchClassComboBoxBoardName.Text == "")
            {
                MessageBox.Show("Search selection cannot be empty");
            }
            else
            {
                DataRow row;
                SqlCommand command = new SqlCommand("select top 20 BoardName,SubjectName,ClassLevel,FirstName+' '+LastName from Board,Subject,ClassLevel,Teacher");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    this.studentGridAddCourse.Rows.Add(rd[0], rd[1], rd[2]);
                }
                rd.Close();


            }
        }

        private void SearchClassComboBoxClassLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select FirstName+' '+LastName from Teacher,Teaching,Board,Subject,ClassLevel where Teacher.TeacherID = Teaching.TeacherID and (Teaching.SubjectID = Subject.SubjectID) and (Teaching.ClassLevelID = ClassLevel.ID) and (Teaching.BoardID = Board.ID) and SubjectName = '" + (SearchClassComboBoxSubjects.SelectedItem.ToString()) + "' and BoardName = '" + (SearchClassComboBoxBoardName.SelectedItem.ToString()) + "' and ClassLevel = '" + (SearchClassComboBoxClassLevel.SelectedItem.ToString()) + "'");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader rd = command.ExecuteReader();
            SearchClassComboBoxSubjects.Items.Clear();
            while (rd.Read())
            {
                SearchClassComboBoxSubjects.Items.Add(rd["SubjectName"]);
            }
            rd.Close();
        }
    }
}
