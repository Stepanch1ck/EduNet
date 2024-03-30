using MySql.Data.MySqlClient;
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

namespace EduNet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void CloseLogin1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string loginUser = login.Text;
            string passUser = password.Text;
            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Студент авторизован");
                this.Close();
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Среди студентов нет такового пользователя");
            }
            command = new MySqlCommand("SELECT * FROM `admin` WHERE `login` = @uLT AND `password` = @uPT", db.GetConnection());
            command.Parameters.Add("@uLT", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPT", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Администратор авторизован");
                this.Close();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует или вы ввели неверный пароль");
            }
        }


        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = String.Empty;
        }

        private void login_MouseClick(object sender, MouseEventArgs e)
        {
            login.Text = String.Empty;
        }
    }
}
