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
    public partial class TakeAttendance : Form
    {
        SqlConnection connection;
        public TakeAttendance(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void TakeAttendancedateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
