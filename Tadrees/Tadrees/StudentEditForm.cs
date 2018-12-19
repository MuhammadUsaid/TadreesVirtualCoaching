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
    public partial class StudentEditForm : Form
    {
        SqlConnection connection;
        public StudentEditForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void StudentEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
