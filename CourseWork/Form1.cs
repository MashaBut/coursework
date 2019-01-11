using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Exit_Click(object sender, EventArgs e)
        { Close();}

        public void CloseForm_Click(object sender, EventArgs e)
        {
            InfoClient.Text = "Выполняется запрос...";
            PutClient client = new PutClient(NameClient.Text, PasswordClient.Text);
            if (client.rez == PasswordClient.Text)
            {
               
               Hide();
               WorkFuild clientFuild = new WorkFuild();
               clientFuild.Show();
            }
            else
            {
                InfoClient.Text = "Неверно введен логин или пароль!";
            }
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            Hide(); 
            CheckIn check = new CheckIn();
            check.Show();
        }
    }
}
