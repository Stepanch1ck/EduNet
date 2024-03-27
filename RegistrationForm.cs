﻿using MySql.Data.MySqlClient;
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
            if(surname.Text == "Фамилия" || surname.Text == null)
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (name.Text == "Имя" || name.Text == null)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (patronomyc.Text == "Отчество" || patronomyc.Text == null)
            {
                MessageBox.Show("Введите отчество");
                return;
            }
            if (emailAddress.Text == "Эл. почта" || emailAddress.Text == null)
            {
                MessageBox.Show("Введите электронную почту");
                return;
            }
            if (group.Text == "Группа" || group.Text == null)
            {
                MessageBox.Show("Введите группу");
                return;
            }
            if (comeUpWithPassword.Text == "Придумайте пароль" || comeUpWithPassword.Text == null)
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (repeatPassword.Text == "Повторите пароль" || repeatPassword.Text == null)
            {
                MessageBox.Show("Повторите пароль");
                return;
            }
            DBClass dbc = new DBClass();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `student` (`Surname`, `Name`, `Patronomyc`, `ProfilePicture`, `Login`, `Password`, `Group`) VALUES (@surname, @name, @patronomyc, NULL, @login, @pass, @group)", dbc.GetConnection());
            mySqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            mySqlCommand.Parameters.Add("@patronomyc", MySqlDbType.VarChar).Value = patronomyc.Text;
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = emailAddress.Text;
            mySqlCommand.Parameters.Add("@group", MySqlDbType.Int16).Value = group.Text;
            if (comeUpWithPassword.Text.Equals(repeatPassword.Text))
            {
                mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = repeatPassword.Text;
                dbc.OpenConnection();
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы успешно зарегистрировались");
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрироваться");
                }
                dbc.CloseConnection();
                this.Close();
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Пароль неверный");
            } 
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

        private void surname_Click(object sender, EventArgs e)
        {
            surname.Text = String.Empty;
        }

        private void name_Click(object sender, EventArgs e)
        {
            name.Text = String.Empty;
        }

        private void patronomyc_Click(object sender, EventArgs e)
        {
            patronomyc.Text = String.Empty;
        }

        private void emailAddress_Click(object sender, EventArgs e)
        {
            emailAddress.Text = String.Empty;
        }

        private void comeUpWithPassword_Click(object sender, EventArgs e)
        {
            comeUpWithPassword.Text = String.Empty;
        }

        private void group_Click(object sender, EventArgs e)
        {
            group.Text = String.Empty;
        }

        private void repeatPassword_Click(object sender, EventArgs e)
        {
            repeatPassword.Text = String.Empty;
        }
    }
}
