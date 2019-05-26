using System;
using MySql.Data.MySqlClient;
using CourseWork.TestLight;

namespace CourseWork.TestMiddle
{
    class FillingMiddleTest:BuildTestForm
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;");
        public FillingMiddleTest(int k):base(k)
        { }
        public override void Search()
        {
            conn.Open();
            foreach (int i in number)
            {
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                tlQ.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));
                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT FirstAns FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                trueAns.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));
            }
        }
        public void AllAnswers()
        {
            foreach (int i in number)
            {
                MySqlCommand sqlCommand6 = new MySqlCommand($"SELECT FirstAns FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                ErrorAns.Add(Convert.ToString(sqlCommand6.ExecuteScalar()));
                MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT Error1Ans FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                ErrorAns.Add(Convert.ToString(sqlCommand3.ExecuteScalar()));
                MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT Error2Ans FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                ErrorAns.Add(Convert.ToString(sqlCommand4.ExecuteScalar()));
                MySqlCommand sqlCommand5 = new MySqlCommand($"SELECT Error3Ans FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                ErrorAns.Add(Convert.ToString(sqlCommand5.ExecuteScalar()));
            }
            conn.Close();
        }
    }
}
