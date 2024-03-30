using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduNet
{
    public partial class AdminForm : Form
    {
        private DataTable table = null;
        private MySqlDataAdapter adapter = null;
        public AdminForm()
        {
            InitializeComponent();
        }

        void scheduleTeacher_Click(object sender, EventArgs e)
        {
            performancePanel.Visible = false;
            schedulePanel.Visible = true;
            var dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM lesson";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            tableScheduleAdmin.Visible = true;
            tableScheduleAdmin.DataSource = table;
            dbc.CloseConnection();
        }

        void performanceJournal_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;
            performancePanel.Visible = true;
            var dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM performance";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            performanceeJournal.Visible = true;
            performanceeJournal.DataSource = table;
            dbc.CloseConnection();
        }
    }
}