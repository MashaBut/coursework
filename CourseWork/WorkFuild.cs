using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class WorkFuild : Form
    {
        public WorkFuild()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WriteTest_Click(object sender, EventArgs e)
        {
            panel3.Height = WriteTest.Height;
        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }
    }
}
