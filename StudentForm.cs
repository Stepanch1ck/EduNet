using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void GetSQLrequest()
        {
            DBClass dbc = new DBClass();
            dbc.OpenConnection();
            string query = "SELECT * FROM lesson";
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
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `student` (`Surname`, `Name`, `Patronomyc`, `Login`, `Password`, `Group`) VALUES (@surname, @name, @patronomyc, @login, @password, @group)", dbc.GetConnection());
            RegistrationForm form = new RegistrationForm();

            mySqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = editSurname.Text;
            mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = editName.Text;
            mySqlCommand.Parameters.Add("@patronomyc", MySqlDbType.VarChar).Value = editPatronomyc.Text;
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = editEmail.Text;
            try
            {
                string value = editGroup.Rows[2].Cells[8].Value.ToString();
                string value1 = editGroup.Rows[3].Cells[6].Value.ToString();
                mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = 6575;
                mySqlCommand.Parameters.Add("@group", MySqlDbType.Int16).Value = 321;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
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
            GetSQLrequest();
            tableSchedule.Visible = true;
            tableSchedule.DataSource = table;
        }
    }
}
