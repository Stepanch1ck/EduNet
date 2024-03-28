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
        private DataTable table = null;
        private void GetSQLrequest()
        {
            DBClass dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM lesson";
            //MySqlCommand command = new MySqlCommand(query, dbc.GetScheConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
        }
        public StudentForm()
        {
            InitializeComponent();
        }
        private void ScheduleStudent_Click(object sender, EventArgs e)
        {
            edit.Visible = false;
            schedulePanel.Visible = true;
            GetSQLrequest();
            tableSchedule.Visible = true;
            tableSchedule.DataSource = table;
        }

        private void nameStudent_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;
            edit.Visible = true;
        }
    }
}
