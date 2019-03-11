using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork.TestLight
{
    public partial class TestLight : Form
    {
        public TestLight()
        {
            InitializeComponent();
            TestL test = new TestL();
            test.Search();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        class TestL {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;");
            List<string> tlQ = new List<string>();
            List<string> trueAns = new List<string>();
            List<string> ErrorAns = new List<string>();
            HashSet<int> number = new HashSet<int>();
            Random Random = new Random();
            int idMAX,idMIN = 0;
            public TestL(){
                conn.Open();
                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT MAX(id) FROM coursework.{LOG.NameTable}", conn);
                idMAX = Convert.ToInt32(sqlCommand2.ExecuteScalar());
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT MIN(id) FROM coursework.{LOG.NameTable}", conn);
                idMIN = Convert.ToInt32(sqlCommand1.ExecuteScalar());
                while (number.Count < 8)
                {
                    number.Add(Random.Next(idMIN, idMAX));
                }
                conn.Close();
            }
            public void Search()
            {
                conn.Open();
                foreach(int i in number)
                {
                    MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                    tlQ.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));
                    MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT FirstAns FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                    trueAns.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));
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
        private void TestLight_Load(object sender, EventArgs e)
        {

        }
    }
}
