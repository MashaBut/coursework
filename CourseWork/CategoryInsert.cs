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

namespace CourseWork
{
    public partial class CategoryInsert : Form
    {
        public CategoryInsert()
        {
            InitializeComponent();
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CaterogoryInsert_Load(object sender, EventArgs e)
        {
            this.Region = new Region(Form1.Rec.RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 20));
        }

        public void INSERT_Click(object sender, EventArgs e)
        {
            bool rez = true;
            string nameForCreateCategory = "";
            string nameCategory = Createcategory.Text;
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection sqlConnection = new MySqlConnection(connStr);
            sqlConnection.Open();
            string selectPassword = $"select distinct category from coursework.{LOG.LOGIN} where category='{Createcategory.Text}'";
            MySqlCommand commandPassword = new MySqlCommand(selectPassword, sqlConnection);
            try
            {
                rez = false;
                string rezPassword = commandPassword.ExecuteScalar().ToString();
                InfoClient.Text = "!";
            }
            catch
            {
                if (nameCategory.Contains(" "))
                {
                    nameForCreateCategory=nameCategory.Replace(' ', '_');
                    rez = true;
                    InfoClient.Text = "";
                }
                else
                {
                    nameForCreateCategory = Createcategory.Text;
                    rez = true;
                }
            }
            if (rez)
            {
                string insert = $"insert coursework.{LOG.LOGIN}(category) values ('{Createcategory.Text}')";
                MySqlCommand command = new MySqlCommand(insert, sqlConnection);
                command.ExecuteNonQuery();
                string create = $"CREATE TABLE `coursework`.`{LOG.LOGIN}_{nameForCreateCategory}` (`id` INT NOT NULL AUTO_INCREMENT, `Question` VARCHAR(256) NOT NULL, `FirstAns` VARCHAR(256) NOT NULL, `SecondAns` VARCHAR(256) NULL,PRIMARY KEY(`id`), UNIQUE INDEX `Question_UNIQUE` (`Question` ASC) VISIBLE, UNIQUE INDEX `FirstAns_UNIQUE` (`FirstAns` ASC) VISIBLE, UNIQUE INDEX `SecondAns_UNIQUE` (`SecondAns` ASC) VISIBLE)";
                MySqlCommand command1 = new MySqlCommand(create, sqlConnection);
                command1.ExecuteNonQuery();
                Library library = new Library();
                library.List();
                this.Close();
            }
            sqlConnection.Close();
        }
    }
}
