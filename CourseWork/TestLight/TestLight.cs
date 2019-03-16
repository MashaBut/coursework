using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace CourseWork.TestLight
{
    public partial class TestLight : Form
    {
        public TestLight()
        {
            InitializeComponent();
            Thread myThread = new Thread(new ThreadStart(Built2));
            myThread.Start(); // запускаем поток
            Built1();
        }
        Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        HashSet<int> OrderTwo = new HashSet<int>();
        FilllingOutForms filllingOutForms = new FilllingOutForms();
        private void Built1()
        {
            Q1.Text = filllingOutForms.AddQ(0);
            BuildOrder(0,4);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 1:
                        Answer1_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 2:
                        Answer1_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 3:
                        Answer1_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 0:
                        Answer1_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            Q2.Text = filllingOutForms.AddQ(1);
            Order.Clear();
            BuildOrder(4,8);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 4:
                        Answer2_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 5:
                        Answer2_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 6:
                        Answer2_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 7:
                        Answer2_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            Q3.Text = filllingOutForms.AddQ(2);
            Order.Clear();
            BuildOrder(8, 12);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 8:
                        Answer3_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 9:
                        Answer3_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 10:
                        Answer3_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 11:
                        Answer3_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            Q4.Text = filllingOutForms.AddQ(3);
            Order.Clear();
            BuildOrder(12, 16);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 12:
                        Answer4_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 13:
                        Answer4_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 14:
                        Answer4_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 15:
                        Answer4_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            Q5.Text = filllingOutForms.AddQ(4);
            Order.Clear();
            BuildOrder(16, 20);
            foreach (int i in Order)
            {
                switch (i)
                {
                    case 16:
                        Answer5_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 17:
                        Answer5_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 18:
                        Answer5_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 19:
                        Answer5_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            Order.Clear();
        }
        private void Built2()
        {
            Q6.Text = filllingOutForms.AddQ(5);
            BuildOrderTwo(20, 24);
            foreach (int i in OrderTwo)
            {
                switch (i)
                {
                    case 20:
                        Answer6_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 21:
                        Answer6_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 22:
                        Answer6_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 23:
                        Answer6_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            OrderTwo.Clear();
            Q7.Text = filllingOutForms.AddQ(6);
            BuildOrderTwo(24, 28);
            foreach (int i in OrderTwo)
            {
                switch (i)
                {
                    case 24:
                        Answer7_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 25:
                        Answer7_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 26:
                        Answer7_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 27:
                        Answer7_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            OrderTwo.Clear();
            Q8.Text = filllingOutForms.AddQ(7);
            BuildOrderTwo(28, 32);
            foreach (int i in OrderTwo)
            {
                switch (i)
                {
                    case 28:
                        Answer8_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 29:
                        Answer8_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 30:
                        Answer8_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 31:
                        Answer8_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            OrderTwo.Clear();
            Q9.Text = filllingOutForms.AddQ(8);
            BuildOrderTwo(32, 36);
            foreach (int i in OrderTwo)
            {
                switch (i)
                {
                    case 32:
                        Answer9_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 33:
                        Answer9_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 34:
                        Answer9_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 35:
                        Answer9_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
            OrderTwo.Clear();
            Q10.Text = filllingOutForms.AddQ(9);
            BuildOrderTwo(36, 40);
            foreach (int i in OrderTwo)
            {
                switch (i)
                {
                    case 36:
                        Answer10_1.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 37:
                        Answer10_2.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 38:
                        Answer10_3.Text = filllingOutForms.AddErrorAns(i);
                        break;
                    case 39:
                        Answer10_4.Text = filllingOutForms.AddErrorAns(i);
                        break;
                }
            }
        }
        void BuildOrder(int a,int b)
        {
            while(Order.Count<4)
            {
                Order.Add(Random.Next(a, b));
            }
        }
        void BuildOrderTwo(int a, int b)
        {
            while (OrderTwo.Count < 4)
            {
                OrderTwo.Add(Random.Next(a, b));
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TestLight_Load(object sender, EventArgs e)
        {

        }
    }
}
