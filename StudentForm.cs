using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduNet
{
    public partial class StudentForm : Form
    {
        private void GetSQLrequest()
        {
            DBClass dbc = new DBClass();
            dbc.OpenScheConnection();
            string query = "SELECT * FROM schedule";
            MySqlCommand command = new MySqlCommand(query, dbc.GetScheConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }
        public StudentForm()
        {
            InitializeComponent();
        }
        private void ScheduleStudent_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = true;
        }
        private void monday_Click(object sender, EventArgs e)
        { 
            GetSQLrequest();
            tableSchedule.Visible = true;
            DataTable dt = new DataTable();
            tableSchedule.DataSource = dt;
        }
    }
}
