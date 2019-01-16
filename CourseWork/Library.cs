using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class Library : UserControl
    {
        public Library()
        {
            InitializeComponent();
        }
        string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";

        private void Library_Load(object sender, EventArgs e)
        {
            PutCategory put = new PutCategory();
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string selectQuery = "select * from coursework.client";
            DataTable table = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery,conn);
            dataAdapter.Fill(table);
            DatabaseGridView.DataSource = table;
        }

        private void CreateCategory_Click(object sender, EventArgs e)
        {
            CaterogoryInsert insert = new CaterogoryInsert();
            insert.Show();
        }

        class PutCategory
        {
            public PutCategory()
            {
                string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string select = $"select category from coursework.{LOG.LOGIN}";
                MySqlCommand sqlCommand = new MySqlCommand(select, conn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                List<string> infoPutCategory = new List<string>();
                List<string> putCategory = new List<string>();
                while (reader.Read())
                {
                    infoPutCategory.Add($"{LOG.LOGIN}_" + (reader[0].ToString()).ToLower());
                    putCategory.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
