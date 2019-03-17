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
    public partial class Honors : UserControl
    {
        public Honors()
        {
            InitializeComponent();
            
        }
        string connS = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
        DataTable table;
        MySqlDataAdapter dataAdapter;
        private void RezultClient()
        {
            MySqlConnection conn = new MySqlConnection(connS);
            conn.Open();
            try
            {
                string selectQuery = $"select Usename,Test,Right_answers,Date from coursework.honors";
                dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                table = new DataTable();
                dataAdapter.Fill(table);
                DatabaseGridView.DataSource = table;
            }
            catch { }
            conn.Close();
        }

        private void Honors_Load(object sender, EventArgs e)
        {
            RezultClient();
        }

        private void DatabaseGridView_Click(object sender, EventArgs e)
        {
            RezultClient();
        }
    }
}
