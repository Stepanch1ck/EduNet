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

namespace EduNet
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void closeRegistr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            if(surname.Text == "Фамилия")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (name.Text == "Имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (patronomyc.Text == "Отчество")
            {
                MessageBox.Show("Введите отчество");
                return;
            }
            if (emailAddress.Text == "Эл. почта")
            {
                MessageBox.Show("Введите электронную почту");
                return;
            }
            if (group.Text == "Группа")
            {
                MessageBox.Show("Введите группу");
                return;
            }
            if (comeUpWithPassword.Text == "Придумайте пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (repeatPassword.Text == "Повторите пароль")
            {
                MessageBox.Show("Повторите пароль");
                return;
            }
            DBClass dbc = new DBClass();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `student` (`Surname`, `Name`, `Patronomyc`, `ProfilePicture`, `Login`, `Password`, `Group`) VALUES (@surname, @name, @patronomyc, ST_GeomFromText(NULL), @login, @pass, @group)");
            mySqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            mySqlCommand.Parameters.Add("@patronomyc", MySqlDbType.VarChar).Value = patronomyc.Text;
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = emailAddress.Text;
            mySqlCommand.Parameters.Add("@group", MySqlDbType.VarChar).Value = group.Text;
            if (comeUpWithPassword.Text.Equals(repeatPassword.Text))
            {
                mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = repeatPassword.Text;
            }
            else
            {
                MessageBox.Show("error");
            }
            dbc.OpenConnection();
            //if(mySqlCommand.ExecuteNonQuery() == 1)
            //{
                MessageBox.Show("Вы успешно зарегистрировались");
 
            dbc.CloseConnection();
            this.Close();
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }
        public Boolean checkUser()
        {
            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = emailAddress.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = repeatPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь авторизован");
                this.Close();
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует или вы ввели неверный пароль");
            }
            return true;
        }
    }
}
