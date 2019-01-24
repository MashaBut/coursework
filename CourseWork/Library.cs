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

        public string punkt;
        
        DataSet ds = new DataSet();
        DataTable table = new DataTable();

        private void Library_Load(object sender, EventArgs e)
        {
            List();
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
                    infoPutCategory.Add($"{LOG.LOGIN}_" + (reader[0].ToString()).ToLower().Replace(' ', '_'));
                    putCategory.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
        }
        public void List()
        {
            listBox.Items.Clear();
            PutCategory category = new PutCategory();
            string []Name = new string [256];
            listBox.Items.Add("Создать категорию");
            listBox.Items.Add("Обновить категории");
            for (int i = 0; i < category.putCategory.Count; i++)
            {
               Name[i]=category.putCategory[i];
               listBox.Items.Add(Name[i]);
            }
           
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            PutCategory category = new PutCategory();
            for (int j = 0; j <= category.putCategory.Count; j++)
            {
                if (Convert.ToString(listBox.SelectedItem) == "Создать категорию")
                {
                    CategoryInsert insert = new CategoryInsert();
                    insert.Show();
                    List();
                    break;
                }
                if (Convert.ToString(listBox.SelectedItem) == "Обновить категории")
                {
                    List();
                    break;
                }
                if (Convert.ToString(listBox.SelectedItem) != "")
                {
                    if (Convert.ToString(listBox.SelectedItem) == category.putCategory[j])
                    {
                        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;");
                        conn.Open();
                        string selectQuery = $"select Question,FirstAns,SecondAns from coursework.{category.infoPutCategory[j]}";
                        LOG.NameTable = category.infoPutCategory[j];
                        
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                        dataAdapter.Fill(table);
                        DatabaseGridView.DataSource = table;
                        break;
                    }
                }
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            //DataSet d = new DataSet();
            //MySqlDataAdapter update = new MySqlDataAdapter();
            //MySqlCommandBuilder cmbd = new MySqlCommandBuilder(update);
            //update.Update(d,$"coursework.{LOG.NameTable}");
            //d.AcceptChanges();
            //DatabaseGridView.DataSource = d.Tables[LOG.NameTable];
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DatabaseGridView.SelectedRows)
            {
                DatabaseGridView.Rows.Remove(row);
            }
        }
    }
}