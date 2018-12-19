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
    public partial class TeacherEditForm : Form
    {
        SqlConnection connection;
        public TeacherEditForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUpStudentButtonSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
