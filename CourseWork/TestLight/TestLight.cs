using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static CourseWork.Library;

namespace CourseWork.TestLight
{
    public partial class TestLight : Form
    {
        public TestLight()
        {
            InitializeComponent();
            TestL test = new TestL();
            test.SearchQ();
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
            public void SearchQ()
            {
                conn.Open();
                foreach(int i in number)
                {
                    MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT Question FROM coursework.{LOG.NameTable} where id='{i}'", conn);
                    tlQ.Add(Convert.ToString(sqlCommand2.ExecuteReader()));
                }
                conn.Close();
            }
        }
        private void TestLight_Load(object sender, EventArgs e)
        {

        }
    }
}
