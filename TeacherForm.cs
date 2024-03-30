using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EduNet
{
    public partial class TeacherForm : Form
    {
        private DataTable table = null;
        private MySqlDataAdapter adapter = null;
        public TeacherForm()
        {
            InitializeComponent();
        }

        void scheduleTeacher_Click(object sender, EventArgs e)
        {
            editTeacher.Visible = false;
            performancePanel.Visible = false;
            schedulePanel.Visible = true;
            var dbc = new DBClass();
            dbc.OpenConnection();
            var query = "SELECT * FROM lesson";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            tableScheduleAdmin.Visible = true;
            tableScheduleAdmin.DataSource = table;
            dbc.CloseConnection();
        }

        void performanceJournal_Click(object sender, EventArgs e)
        {
            editTeacher.Visible = false;
            schedulePanel.Visible = false;
            performancePanel.Visible = true;
            var dbc = new DBClass();
            dbc.OpenConnection();
            var query = "SELECT * FROM performance";
            adapter = new MySqlDataAdapter(query, dbc.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            performanceeJournal.Visible = true;
            performanceeJournal.DataSource = table;
            dbc.CloseConnection();
        }

        private void editTeacherProfile_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;
            performancePanel.Visible = false;
            editTeacher.Visible = true;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            var dbc = new DBClass();
            var mySqlCommand = new MySqlCommand("UPDATE admin SET `surname` = @uS, `name` = @uN, `patronomyc` = @uP, `login` = @uL WHERE ID = @uI", dbc.GetConnection());
            var dataTable = new DataTable("student");
            mySqlCommand.Parameters.Add("@uS", MySqlDbType.VarChar).Value = editSurname.Text;
            mySqlCommand.Parameters.Add("@uN", MySqlDbType.VarChar).Value = editName.Text;
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = editPatronomyc.Text;
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = editEmail.Text;
            mySqlCommand.Parameters.Add("@uI", MySqlDbType.Int16).Value = 1;
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
        void editSurname_Click(object sender, EventArgs e)
        {
            editSurname.Text = String.Empty;
        }

        void editName_Click(object sender, EventArgs e)
        {
            editName.Text = String.Empty;
        }

        void editPatronomyc_Click(object sender, EventArgs e)
        {
            editPatronomyc.Text = String.Empty;
        }

        void editEmail_Click(object sender, EventArgs e)
        {
            editEmail.Text = String.Empty;
        }
    }
}