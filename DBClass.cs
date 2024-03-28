using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EduNet
{
    internal class DBClass
    {
        MySqlConnection connection = new MySqlConnection("host=localhost;port=3306;user=root;password=root;database=edu");
        MySqlConnection connectionSche = new MySqlConnection("host=localhost;port=3306;user=root;password=root;database=Schedule");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void OpenScheConnection()
        {
            if (connectionSche.State == System.Data.ConnectionState.Closed)
            {
                connectionSche.Open();
            }
        }
        public void CloseScheConnection()
        {
            if (connectionSche.State == System.Data.ConnectionState.Open)
            {
                connectionSche.Close();
            }
        }
        public MySqlConnection GetScheConnection()
        {
            return connectionSche;
        }
    }
}
