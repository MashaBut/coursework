﻿using MySql.Data.MySqlClient;

namespace CourseWork
{
    class CheckInClient : CheckIn
    {
        string selectLogin, selectPassword;
        public string rezLogin, rezPassword;
        string insert;
        public bool finish1=true, finish2 = true;
        public CheckInClient(string Name, string Username, string Login, string Password)
        {
            if (Name != "" && Username != "" && Login != "" && Password != "")
            {
                string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                selectLogin = $"select distinct Login from coursework.client where Login='{Login}'";//
                MySqlCommand commandLogin = new MySqlCommand(selectLogin, conn);
                try
                {
                    rezLogin = commandLogin.ExecuteScalar().ToString();
                    if(rezLogin==null)
                    {finish1 = true;}
                    else
                    { finish1 = false; }
                }
                catch { }

                selectPassword = $"select distinct Password from coursework.client where Password='{Password}'";//
                MySqlCommand commandPassword = new MySqlCommand(selectPassword, conn);
                try
                {   rezPassword = commandPassword.ExecuteScalar().ToString();
                    if(rezPassword==null)
                    { finish2 = true; }
                    else 
                    { finish2 = false; }
                }
                catch { }

                if (finish1 && finish2)
                {
                    insert = $"insert coursework.client(Name,Usename,Login,Password) values ('{Name}','{Username}','{Login}','{Password}')";//
                    MySqlCommand command = new MySqlCommand(insert, conn);
                    command.ExecuteNonQuery();
                    LOG.LOGIN = Login;
                    string sqlClient = $"CREATE TABLE `coursework`.`{Login}` (`id` INT NOT NULL AUTO_INCREMENT, `category` VARCHAR(100) NOT NULL, PRIMARY KEY(`id`))";
                    MySqlCommand command1 = new MySqlCommand(sqlClient, conn);
                    command1.ExecuteNonQuery();

                    
                }
                conn.Close();
            }
        }
    }
}