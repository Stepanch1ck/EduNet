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
        private SqlConnection sqlconn;

        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["EduDB"].ConnectionString );
            sqlconn.Open();
            if (sqlconn.State == ConnectionState.Open) 
            {
                MessageBox.Show("Подключение установленно");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {

        }
    }
     
}
