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
            PutCategory category = new PutCategory();
            Hand();
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string selectQuery = $"select * from coursework.{category.infoPutCategory[0]}";
            DataTable table = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery,conn);
            dataAdapter.Fill(table);
            DatabaseGridView.DataSource = table;
        }
        ToolStripMenuItem[] tool = new ToolStripMenuItem[256];

        public void Hand()
        {
            PutCategory category = new PutCategory();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Категории");
            fileItem.Image = Image.FromFile(Environment.CurrentDirectory + "\\cube.png");
            
            for(int i=0;i<category.putCategory.Count;i++)
            {  tool[i] = new ToolStripMenuItem(category.putCategory[i]);
                fileItem.DropDownItems.Add(tool[i]);
                tool[i].Image = Image.FromFile(Environment.CurrentDirectory + "\\filetext.png");
                tool[i].Click += MenuItem_Click;
            }
            ToolStripMenuItem CreateCategory = new ToolStripMenuItem("Создать категорию");
            CreateCategory.Image = Image.FromFile(Environment.CurrentDirectory + "\\edit.png");

            fileItem.DropDownItems.Add(CreateCategory);
            CreateCategory.Click += Finish_Click;
            menuStrip1.Items.Add(fileItem);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            PutCategory category = new PutCategory();
            for (int i = 0; i < category.putCategory.Count; i++)
            {
                if (Convert.ToString(sender) == category.putCategory[i])
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    string selectQuery = $"select * from coursework.{category.infoPutCategory[i]}";
                    DataTable table = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                    dataAdapter.Fill(table);
                    DatabaseGridView.DataSource = table;
                    break;
                }  
            }
        }

         private void Finish_Click(object sender, EventArgs e)
         {
             CaterogoryInsert insert = new CaterogoryInsert();
             insert.Show();
         }

        public class PutCategory
        {
            public List<string> putCategory = new List<string>();
            public List<string> infoPutCategory = new List<string>();
            public PutCategory()
            {
                putCategory.Clear();
                string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string select = $"select category from coursework.{LOG.LOGIN}";
                MySqlCommand sqlCommand = new MySqlCommand(select, conn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                
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
