using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UpdateClient updateClient = new UpdateClient(UpdateName.Text,UpdateUsername.Text,UpdatePassword.Text);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {

        }
    }
}
