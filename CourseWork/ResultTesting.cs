using System;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    class ResultTesting
    {
        public void PushSQL(int trueAns,int Ans,string nameTest)
        {
            double push = Math.Round((double)trueAns * 100 / Ans, 2);
            string rez="";
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sqlClient = $"select Usename from coursework.client where Login='{LOG.LOGIN}'";
                MySqlCommand command = new MySqlCommand(sqlClient, conn);
                try {rez = command.ExecuteScalar().ToString(); }
                catch { }
                conn.Close();
            }
            catch { }
            conn.Open();
            string pushInSQL = $"insert coursework.honors (Usename,Test,Right_answers,Date) values('{rez}','{nameTest}','{push}%','{DateTime.Now}')";
            MySqlCommand sqlCommand = new MySqlCommand(pushInSQL, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
