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
    public partial class TeacherForm : Form
    {
        SqlConnection connection;
        string userId;
        public TeacherForm(SqlConnection con, string id)
        {
            InitializeComponent();
            connection = con;
            userId = id;
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

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void teacherLabelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchClassLLabelSubjects_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void teacherGridSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void StudentLabelAdd_Click(object sender, EventArgs e)
        {
            string query = "select ID from Board where BoardName = '" + (SearchClassComboBoxBoardName.SelectedItem.ToString()) + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int boardID = (int)command.ExecuteScalar();
            query = "select SubjectID from Subject where SubjectName = '" + (SearchClassComboBoxSubjects.SelectedItem.ToString()) + "'";
            command = new SqlCommand(query, connection);
            int SubjectID = (int)command.ExecuteScalar();
            query = "select ID  from ClassLevel where ClassLevel = '" + (SearchClassComboBoxClassLevel.SelectedItem.ToString()) + "'";
            command = new SqlCommand(query, connection);
            int LevelID = (int)command.ExecuteScalar();

            string capacity = SearchcourseTextBoxCapacity.Text;
            DateTime startDate = (DateTime.Parse(SearchcourseDateStartDate.Value.ToShortDateString())).Date;
            DateTime endDate = (DateTime.Parse(SearchcourseDateEndDate.Value.ToShortDateString())).Date;
            int startTime = (int)TimingsComboBoxTime.SelectedItem;

            query = "insert into Class(BoardID,SubjectID,ClassLevelID,StartDate,EndDate,Capacity) values("
                    + boardID + "," + SubjectID + "," + LevelID + "," + startDate + "," + endDate + "," + capacity + ")";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            List<string> DayList = new List<string>();
            if (studentCheckboxDayMonday.Checked)
            { DayList.Add("Monday"); }
            if (studentCheckboxDayTuesday.Checked)
            { DayList.Add("Tuesday"); }
            if (studentCheckboxDayWednesday.Checked)
            { DayList.Add("Wednesday"); }
            if (studentCheckboxDayThursday.Checked)
            { DayList.Add("Thursday"); }
            if (studentCheckboxDayFriday.Checked)
            { DayList.Add("Friday"); }
            if (studentCheckboxDaySaturday.Checked)
            { DayList.Add("Saturday"); }
            if (studentCheckboxDaySunday.Checked)
            { DayList.Add("Sunday"); }

            for (int i = 0; i < DayList.Count; i++)
            {
                query = "insert into Class_has_Days(ClassID, DaysID) values (select ClassID from Class, select ID from Days where [Day] ="
                + DayList[i];
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
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

        private void teacherLabelEditProfile_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form = new TeacherEditForm(connection, userId);
            form.Show();
            form.FormClosed += (s, args) => this.Show();
        }
    }
}
