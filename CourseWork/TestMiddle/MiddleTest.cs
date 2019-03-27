using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork.TestMiddle
{
    public partial class MiddleTest : Form
    {
        public MiddleTest()
        {
            InitializeComponent();
            //Thread myThread = new Thread(new ThreadStart());
            //myThread.Start();
            Built1();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        HashSet<int> OrderTwo = new HashSet<int>();
        FillingFormsMT filling = new FillingFormsMT();
        ResultTesting ResultTesting = new ResultTesting();
        List<string> AnswersClient = new List<string>();
        private void Built1()
        {
            Q1.Text = filling.AddQ(0);
            BuildOrder(0, 4);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 1:
                        Answer1_1.Text = filling.AddErrorAns(i);
                        break;
                    case 2:
                        Answer1_2.Text = filling.AddErrorAns(i);
                        break;
                    case 3:
                        Answer1_3.Text = filling.AddErrorAns(i);
                        break;
                    case 0:
                        Answer1_4.Text = filling.AddErrorAns(i);
                        break;
                }
            }
            Q2.Text = filling.AddQ(1);
            Order.Clear();
            BuildOrder(4, 8);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 4:
                        Answer2_1.Text = filling.AddErrorAns(i);
                        break;
                    case 5:
                        Answer2_2.Text = filling.AddErrorAns(i);
                        break;
                    case 6:
                        Answer2_3.Text = filling.AddErrorAns(i);
                        break;
                    case 7:
                        Answer2_4.Text = filling.AddErrorAns(i);
                        break;
                }
            }
            Q3.Text = filling.AddQ(2);
            Order.Clear();
            BuildOrder(8, 12);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 8:
                        Answer3_1.Text = filling.AddErrorAns(i);
                        break;
                    case 9:
                        Answer3_2.Text = filling.AddErrorAns(i);
                        break;
                    case 10:
                        Answer3_3.Text = filling.AddErrorAns(i);
                        break;
                    case 11:
                        Answer3_4.Text = filling.AddErrorAns(i);
                        break;
                }
            }
            Q4.Text = filling.AddQ(3);
            Order.Clear();
            BuildOrder(12, 16);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 12:
                        Answer4_1.Text = filling.AddErrorAns(i);
                        break;
                    case 13:
                        Answer4_2.Text = filling.AddErrorAns(i);
                        break;
                    case 14:
                        Answer4_3.Text = filling.AddErrorAns(i);
                        break;
                    case 15:
                        Answer4_4.Text = filling.AddErrorAns(i);
                        break;
                }
            }
            Q5.Text = filling.AddQ(4);
            Order.Clear();
            BuildOrder(16, 20);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 16:
                        Answer5_1.Text = filling.AddErrorAns(i);
                        break;
                    case 17:
                        Answer5_2.Text = filling.AddErrorAns(i);
                        break;
                    case 18:
                        Answer5_3.Text = filling.AddErrorAns(i);
                        break;
                    case 19:
                        Answer5_4.Text = filling.AddErrorAns(i);
                        break;
                }
            }
            Order.Clear();
        }
        void BuildOrder(int a, int b)
        {
            while (Order.Count < 4)
            {
                Order.Add(Random.Next(a, b));
            }
        }



        private void Answer1_1_Click_1(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.Teal;
            Answer1_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer1_2_Click_1(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_2.BackColor = Color.Teal;
            Answer1_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer1_3_Click_1(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_3.BackColor = Color.Teal;
            Answer1_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer1_4_Click_1(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer1_4.BackColor = Color.Teal;
        }

        private void Answer2_1_Click_1(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.Teal;
            Answer2_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer2_2_Click_1(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_2.BackColor = Color.Teal;
            Answer2_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer2_3_Click_1(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_3.BackColor = Color.Teal;
            Answer2_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer2_4_Click_1(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer2_4.BackColor = Color.Teal;
        }

        private void Answer3_1_Click_1(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.Teal;
            Answer3_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer3_2_Click_1(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_2.BackColor = Color.Teal;
            Answer3_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer3_3_Click_1(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_3.BackColor = Color.Teal;
            Answer3_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer3_4_Click_1(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer3_4.BackColor = Color.Teal;
        }

        private void Answer4_1_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.Teal;
            Answer4_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer4_2_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_2.BackColor = Color.Teal;
            Answer4_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer4_3_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_3.BackColor = Color.Teal;
            Answer4_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer4_4_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer4_4.BackColor = Color.Teal;
        }

        private void Answer5_1_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.Teal;
            Answer5_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer5_2_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_2.BackColor = Color.Teal;
            Answer5_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer5_3_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_3.BackColor = Color.Teal;
            Answer5_4.BackColor = Color.FromArgb(0, 50, 50);
        }

        private void Answer5_4_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_2.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_3.BackColor = Color.FromArgb(0, 50, 50);
            Answer5_4.BackColor = Color.Teal;
        }
    }
}
