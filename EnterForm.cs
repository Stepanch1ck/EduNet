using System;
using System.Windows.Forms;



namespace EduNet
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        void EnterForm_Load(object sender, EventArgs e)
        {
            var dBClass = new DBClass();
            dBClass.OpenConnection();
            dBClass.GetConnection();
        }

        void LoginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        void RegistrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
        void NameEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы не вошли в аккаунт");
        }
    }
     
}
