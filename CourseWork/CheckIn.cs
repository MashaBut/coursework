using System;
using System.Drawing;

using System.Windows.Forms;

namespace CourseWork
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void ExitWithCheckIn_Click(object sender, EventArgs e)
        { Application.Exit();}

        private void CloseForm_Click(object sender, EventArgs e)
        {
            CheckInClient check = new CheckInClient(NewName.Text, NewUsename.Text, NewLogin.Text, NewPassword.Text);
            if (check.rezLogin == NewLogin.Text)
            {
                infoLogin.Text = "!";
            }
            else
            {
                infoLogin.Text = "";
            }
            if (check.rezPassword == NewPassword.Text)
            {
                infoPassword.Text = "!";
            }
            else
            {
                infoPassword.Text = "";
            }
            if (check.finish1 && check.finish2)
            {
                Close();
                WorkFuild clientFuild = new WorkFuild();
                clientFuild.Show();
            }
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            this.Region = new Region(Form1.Rec.RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 20));
        }
    }
}
