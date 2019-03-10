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

        private void honors1_Load(object sender, EventArgs e)
        {

        }

        private void WorkFuild_Load(object sender, EventArgs e)
        {
            
        }
    }
}
