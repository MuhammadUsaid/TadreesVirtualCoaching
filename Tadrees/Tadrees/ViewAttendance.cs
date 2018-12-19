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
    public partial class ViewAttendance : Form
    {
        SqlConnection connection;
        public ViewAttendance(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {

        }
    }
}
