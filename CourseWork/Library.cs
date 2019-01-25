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
        BindingSource bsource = new BindingSource();
        MySqlDataAdapter dataAdapter;
        MySqlCommandBuilder commandBuilder;
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
                    try
                    {
                        dataAdapter.Update(ds);
                        ds.Clear();
                    }
                    catch { }
                    if (Convert.ToString(listBox.SelectedItem) == category.putCategory[j])
                    {
                       
                        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;");
                        conn.Open();
                        string selectQuery = $"select Question,FirstAns,SecondAns from coursework.{category.infoPutCategory[j]}";
                        LOG.NameTable = category.infoPutCategory[j];
                        
                        dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                       
                        dataAdapter.Fill(ds);
                        DatabaseGridView.DataSource = ds.Tables[0];
                        conn.Close();
                        break;
                    }
                }
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;"))
            {
                conn.Open();
                string selectQuery = $"select Question,FirstAns,SecondAns from coursework.{LOG.NameTable}";
                dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                DataTable dt = ds.Tables[0];
                try
                {
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ds);
                }
                catch
                {
                    MessageBox.Show("Все поля должны быть заполненны!!!");
                }
                // перезагружаем данные
                ds.Clear();
                dataAdapter.Fill(ds);
                DatabaseGridView.DataSource = ds.Tables[0];
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DatabaseGridView.SelectedRows)
            {
                DatabaseGridView.Rows.Remove(row);
            }
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
            dataAdapter.Update(ds);
            ds.Clear();
            dataAdapter.Fill(ds);
            DatabaseGridView.DataSource = ds.Tables[0];
        }

        private void AddToDatabase_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void deleteWithDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DatabaseGridView.SelectedRows)
                {
                    DatabaseGridView.Rows.Remove(row);
                }
            }
            catch
            {
                MessageBox.Show("Все поля должны быть заполненны!!!");
            }
        }

        private void saveToDatabase_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;"))
            {
                string selectQuery = $"select Question,FirstAns,SecondAns from coursework.{LOG.NameTable}";
                connection.Open();
                dataAdapter = new MySqlDataAdapter(selectQuery, connection);
                commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.InsertCommand = new MySqlCommand($"coursework.{LOG.NameTable}", connection);
                dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.InsertCommand.Parameters.Add(new MySqlParameter("Question", MySqlDbType.VarChar, 50, "Question"));
            //    dataAdapter.InsertCommand.Parameters.Add(new MySqlParameter("@age", MySqlDbType.VarChar, 0, "Age"));

              //  MySqlParameter parameter = dataAdapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            //    parameter.Direction = ParameterDirection.Output;

                dataAdapter.Update(ds);
            }
        }
    }
}