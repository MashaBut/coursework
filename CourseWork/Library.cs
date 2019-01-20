﻿using System;
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
            List();
            listBox1_SelectedIndexChanged(sender, e);
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
            if (Convert.ToString(listBox.SelectedItem) == "Создать категорию")
            {
                CategoryInsert insert = new CategoryInsert();
                insert.Show();
                List();
                listBox1_SelectedIndexChanged(sender, e);
            }
            for (int j = 0; j <= category.putCategory.Count; j++)
            {
                if(Convert.ToString(listBox.SelectedItem) == "Обновить категории")
                {
                    List();
                    break;
                }
                if (Convert.ToString(listBox.SelectedItem) != "")
                {
                    if (Convert.ToString(listBox.SelectedItem) == category.putCategory[j])
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();
                        string selectQuery = $"select * from coursework.{category.infoPutCategory[j]}";
                        DataTable table = new DataTable();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn);
                        dataAdapter.Fill(table);
                        DatabaseGridView.DataSource = table;
                        break;
                    }
                }
            }
        }
    }
}