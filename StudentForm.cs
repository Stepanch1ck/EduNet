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
        private void GetSQLrequestForLesson()
        {
            DBClass dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM lesson";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
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
            edit.Visible = true;
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
            DBClass dbc = new DBClass();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT FROM `student` (`Surname`, `Name`, `Patronomyc`, `Login`, `Passw, `Group`) VALUES (@surname, @name, @patronomyc, @login, @password, @group)", dbc.GetConnection());
            DataTable dataTable = new DataTable("TableName");
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.EndEdit();
            adapter.Update(dataTable);
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
            edit.Visible = false;
            schedulePanel.Visible = true;
            DBClass dbc = new DBClass();
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
