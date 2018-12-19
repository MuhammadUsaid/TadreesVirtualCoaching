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
    }
}
