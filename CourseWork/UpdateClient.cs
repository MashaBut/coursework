using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    class UpdateClient
    {
        string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
        public UpdateClient(string Name, string Uresname, string Password)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            if(Name!=null)
            {
                string sqlUpdateName = $"update coursework.client set Name = '{Name}' where Login = '{LOG.LOGIN}'";
                MySqlCommand command = new MySqlCommand(sqlUpdateName, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
