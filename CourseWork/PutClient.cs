﻿using MySql.Data.MySqlClient;


namespace CourseWork
{
    class PutClient:Form1
    {
        string sqlClient;//get command
        public string rez;//get rezult command
        public PutClient(string Name,string Password)
        {
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                sqlClient = $"select Password from coursework.client where Login='{Name}'";
                MySqlCommand command = new MySqlCommand(sqlClient, conn);
                try { rez = command.ExecuteScalar().ToString(); }
                catch { }
                conn.Close();
            }
            catch { }
        }
    }
}
