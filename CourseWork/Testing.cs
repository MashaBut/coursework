using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static CourseWork.Library;

namespace CourseWork
{
    public partial class Testing : UserControl
    {
        public Testing()
        {
            InitializeComponent();
            List();
            Level();
        }
        int SizeList = 0;
        PutCategory category = new PutCategory();
        void List()
        {
            BoxForCategory.Items.Clear();
            PutCategory category = new PutCategory();
            BoxForCategory.Items.Add("Обновить категории");
            string[] Name = new string[256];
            for (int i = 0; i < category.putCategory.Count; i++)
            {
                Name[i] = category.putCategory[i];
                BoxForCategory.Items.Add(Name[i]);
            }
        }
        void Level()
        {
            level.Items.Add("Легкий");
            level.Items.Add("Средний");
            level.Items.Add("Сложный");
        }
        private void Test_Click(object sender, EventArgs e)
        {
            if(SizeList>=10)
            {
                LOG.NameTable = Convert.ToString(BoxForCategory.SelectedItem);
                if(Convert.ToString(level.SelectedItem)== "Легкий")
                {
                    TestLight.TestLight testLight = new TestLight.TestLight();
                    testLight.Show();
                }
                else if (Convert.ToString(level.SelectedItem) == "Средний")
                {

                }
                else if(Convert.ToString(level.SelectedItem) == "Сложный")
                {

                }
            }
        }
        private void BoxForCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < category.putCategory.Count; j++)
            {
                if (Convert.ToString(BoxForCategory.SelectedItem) == category.putCategory[j])
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;");
                    conn.Open();
                    MySqlCommand sqlCommand = new MySqlCommand($"SELECT MAX(id) FROM coursework.{category.putCategory[j]}", conn);
                    try
                    {
                        SizeList = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        if (SizeList < 10)
                        {
                            MessageBox.Show(
                                "Таблица должна содержать больше 10 объектов",
                               "                                     Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1
                                );
                        }
                    }
                    catch
                    {
                        MessageBox.Show(
                           "Таблица пуста и не может\n" +
                           " использоваться для тестирования!!!",
                           "                                     Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1
                           );
                    }
                    conn.Close();
                }
                else if (Convert.ToString(BoxForCategory.SelectedItem) == "Обновить категории")
                {
                    List();
                    break;
                }
            }
        }
    }
}
