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
        public StudentForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
