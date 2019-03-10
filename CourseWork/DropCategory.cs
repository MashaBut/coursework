using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static CourseWork.Library;

namespace CourseWork
{
    public partial class DropCategory : Form
    {
        public DropCategory()
        {
            InitializeComponent();
            Category();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Category()
        {
            PutCategory putCategory = new PutCategory();
            for (int i = 0; i < putCategory.putCategory.Count; i++)
            {
                LB.Items.Add(putCategory.putCategory[i]);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string dropCategory = $"drop table {LB.SelectedItem}";
            MySqlCommand command3 = new MySqlCommand(dropCategory, conn);
            command3.ExecuteNonQuery();
            string drop2 = $"delete from coursework.category where category='{LB.SelectedItem}'";
            MySqlCommand command2 = new MySqlCommand(drop2, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            Close();
        }
    }
}
