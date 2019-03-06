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
using System.Windows.Media;

namespace CourseWork
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient(UpdateName.Text, UpdateUsername.Text, UpdatePassword.Text);
        }

        public void DELETE_Click(object sender, EventArgs e)
        {
            LOG.INFO = true;
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string select = $"select category from coursework.{LOG.LOGIN}";
            MySqlCommand my = new MySqlCommand(select, conn);
            MySqlDataReader reader = my.ExecuteReader();
            List <string> list = new List <string>();
            while(reader.Read())
            {
                list.Add((reader[0].ToString()).ToLower());
            }
            reader.Close();
            string dropCategory;
            string Cope;
            foreach (string i in list)
            {
                Cope = $"{LOG.LOGIN}_{i}";
             //   MessageBox.Show(Cope);
                dropCategory = $"drop table {Cope}";
                MySqlCommand command3 = new MySqlCommand(dropCategory, conn);
                command3.ExecuteNonQuery();
            }
            string drop1 = $"delete from coursework.client where Login='{LOG.LOGIN}'";
            MySqlCommand command1 = new MySqlCommand(drop1, conn);
            command1.ExecuteNonQuery();
            string DropForLog = LOG.LOGIN.ToLower();
            string drop2 = $"drop table coursework.{DropForLog}";
            MySqlCommand command2 = new MySqlCommand(drop2, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            Hide();
        }

        private void Sound_Click(object sender, EventArgs e)
        { }
    }
}

