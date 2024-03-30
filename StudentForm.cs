using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EduNet
{
    public partial class StudentForm : Form
    {
        private DataTable table = null;
        private MySqlDataAdapter adapter = null;
        public StudentForm()
        {
            InitializeComponent();
        }
        private void ScheduleStudent_Click(object sender, EventArgs e)
        {
            editStudent.Visible = false;
            schedulePanel.Visible = true;
            DBClass dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM lesson";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            tableSchedule.Visible = true;
            tableSchedule.DataSource = table;
            dbc.CloseConnection();
        }

        private void nameStudent_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;
            editStudent.Visible = true;
        }

        private void editSurname_Click(object sender, EventArgs e)
        {
            editSurname.Text = String.Empty;
        }

        private void editName_Click(object sender, EventArgs e)
        {
            editName.Text = String.Empty;
        }

        private void editPatronomyc_Click(object sender, EventArgs e)
        {
            editPatronomyc.Text = String.Empty;
        }

        private void editEmail_Click(object sender, EventArgs e)
        {
            editEmail.Text = String.Empty;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            var dbc = new DBClass();
            var mySqlCommand = new MySqlCommand("UPDATE student SET `surname` = @uS, `name` = @uN AND `patronomyc` = @uP AND `login` = @uL WHERE ID = @uI", dbc.GetConnection());
            var dataTable = new DataTable("student");
            mySqlCommand.Parameters.Add("@uS", MySqlDbType.VarChar).Value = editSurname.Text;
            mySqlCommand.Parameters.Add("@uN", MySqlDbType.Text).Value = editName.Text;
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = editPatronomyc.Text;
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = editEmail.Text;
            mySqlCommand.Parameters.Add("@uI", MySqlDbType.Int16).Value = 1;
            //bindingSource1.DataSource = dataTable;
            //dataGridView1.DataSource = bindingSource1;
            //bindingSource1.EndEdit();
            //adapter = new MySqlDataAdapter(mySqlCommand);
            //adapter.Update(dataTable);
            dbc.OpenConnection();
            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно изменили профиль");
            }
            else
            {
                MessageBox.Show("Не удалось изменить профиль");
            }
            dbc.CloseConnection();
        }

        private void performance_Click(object sender, EventArgs e)
        {
            editStudent.Visible = false;
            schedulePanel.Visible = true;
            var dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM performance";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            tableSchedule.Visible = true;
            tableSchedule.DataSource = table;
            dbc.CloseConnection();
        }
    }
}
