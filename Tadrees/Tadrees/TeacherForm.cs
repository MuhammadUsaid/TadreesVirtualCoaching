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
        public TeacherForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
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
    }
}
