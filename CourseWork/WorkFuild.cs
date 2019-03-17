using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class WorkFuild : Form
    {
        public WorkFuild()
        {
            InitializeComponent();
            testing2.BringToFront();
        }

        private void Close_Click(object sender, EventArgs e)
        { Application.Exit();}

        private void WorkFuild_Layout(object sender, LayoutEventArgs e)
        {
            if (LOG.INFO == true)
            {
                LOG.INFO = false;
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void WriteTest_Click(object sender, EventArgs e)
        {
            panel3.Height = WriteTest.Height;
            panel3.Top = WriteTest.Top;
            testing2.BringToFront();
        }

        private void Library_Click(object sender, EventArgs e)
        {
            panel3.Height = Library.Height;
            panel3.Top = Library.Top;
            library2.BringToFront();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            panel3.Height = Table.Height;
            panel3.Top = Table.Top;

            honors1.BringToFront();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel3.Height = Set.Height;
            panel3.Top = Set.Top;
            settings1.BringToFront();
        }
    }
}
