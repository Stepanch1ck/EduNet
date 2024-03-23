using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace EduNet
{
    public partial class EnterForm : Form
    {
        //private SqlConnection sqlconn;

        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            DBClass dBClass = new DBClass();
            dBClass.OpenConnection();
            dBClass.GetConnection();
            //sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["EduDB"].ConnectionString );
            //sqlconn.Open();
            //if (sqlconn.State == ConnectionState.Open) 
            //{
            //    MessageBox.Show("Подключение установлено");
            //}
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
        private void NameEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы не вошли в аккаунт");
        }
    }
     
}
