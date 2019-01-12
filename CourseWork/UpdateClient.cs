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
        bool fin;
        string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
        public UpdateClient(string Name, string Username, string Password)
        {
            fin = true;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            if(Name!="")
            {
                string sqlUpdateName = $"update coursework.client set Name = '{Name}' where Login = '{LOG.LOGIN}'";
                MySqlCommand command = new MySqlCommand(sqlUpdateName, conn);
                command.ExecuteNonQuery();
            }
            if(Username!="")
            {
                string sqlUpdateName = $"update coursework.client set Usename = '{Username}' where Login = '{LOG.LOGIN}'";
                MySqlCommand command = new MySqlCommand(sqlUpdateName, conn);
                command.ExecuteNonQuery();
            }
            string rezPassword;
            if (Password!="")
            {
                string selectPassword = $"select distinct Password from coursework.client where Password='{Password}'";
                MySqlCommand commandPassword = new MySqlCommand(selectPassword, conn);
                try
                {
                    rezPassword = commandPassword.ExecuteScalar().ToString();
                    if (rezPassword != null)
                    { fin = false; }
                }
                catch {}
                if (fin==true)
                {
                    string sqlUpdateName = $"update coursework.client set Password = '{Password}' where Login = '{LOG.LOGIN}'";
                    MySqlCommand command = new MySqlCommand(sqlUpdateName, conn);
                    command.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}
