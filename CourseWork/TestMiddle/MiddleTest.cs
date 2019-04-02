using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork.TestMiddle
{
    public partial class MiddleTest : Form
    {
        public MiddleTest()
        {
            InitializeComponent();
            Thread myThread = new Thread(new ThreadStart(Built2));
            myThread.Start();
            Built1();
        }
        Color[] color = { Color.SeaGreen, Color.MediumSeaGreen, Color.Teal, Color.LightSeaGreen };
        Color c1 = Color.SeaGreen, c2 = Color.SeaGreen;
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        static Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        HashSet<int> OrderTwo = new HashSet<int>();
        FillingFormsMT filling = new FillingFormsMT();
        ResultTesting ResultTesting = new ResultTesting();
        List<string> AnswersClient= new List<string>();

        private void Built1()
        {
            Q1.Text = filling.AddQ(0);
            BuildOrder(0, 4);
            int[] mass = new int[4];
            int a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer1_1.Text = filling.AddErrorAns(mass[0]);
            Answer1_2.Text = filling.AddErrorAns(mass[1]);
            Answer1_3.Text = filling.AddErrorAns(mass[2]);
            Answer1_4.Text = filling.AddErrorAns(mass[3]);

            Q2.Text = filling.AddQ(1);
            Order.Clear();
            BuildOrder(4, 8);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer2_1.Text = filling.AddErrorAns(mass[0]);
            Answer2_2.Text = filling.AddErrorAns(mass[1]);
            Answer2_3.Text = filling.AddErrorAns(mass[2]);
            Answer2_4.Text = filling.AddErrorAns(mass[3]);

            Q3.Text = filling.AddQ(2);
            Order.Clear();
            BuildOrder(8, 12);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer3_1.Text = filling.AddErrorAns(mass[0]);
            Answer3_2.Text = filling.AddErrorAns(mass[1]);
            Answer3_3.Text = filling.AddErrorAns(mass[2]);
            Answer3_4.Text = filling.AddErrorAns(mass[3]);
 
            Q4.Text = filling.AddQ(3);
            Order.Clear();
            BuildOrder(12, 16);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer4_1.Text = filling.AddErrorAns(mass[0]);
            Answer4_2.Text = filling.AddErrorAns(mass[1]);
            Answer4_3.Text = filling.AddErrorAns(mass[2]);
            Answer4_4.Text = filling.AddErrorAns(mass[3]);

            Q5.Text = filling.AddQ(4);
            Order.Clear();
            BuildOrder(16, 20);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer5_1.Text = filling.AddErrorAns(mass[0]);
            Answer5_2.Text = filling.AddErrorAns(mass[1]);
            Answer5_3.Text = filling.AddErrorAns(mass[2]);
            Answer5_4.Text = filling.AddErrorAns(mass[3]);
            Order.Clear();
        }
        private void Built2()
        {

            Conformity1_1.Text = filling.AddQ(5);
            Conformity1_2.Text = filling.AddQ(6);
            Conformity1_3.Text = filling.AddQ(7);
            Conformity1_4.Text = filling.AddQ(8);
            BuildOrderTwo(5, 9);
            int a = 0;
            int[] mass = new int[4];

            foreach (int i in OrderTwo)
            {
                mass[a++] = i;
            }
            Juxtapositon1_1.Text = filling.GetTrueAns(mass[0]);
            Juxtapositon1_2.Text = filling.GetTrueAns(mass[1]);
            Juxtapositon1_3.Text = filling.GetTrueAns(mass[2]);
            Juxtapositon1_4.Text = filling.GetTrueAns(mass[3]);

            Conformity2_1.Text = filling.AddQ(9);
            Conformity2_2.Text = filling.AddQ(10);
            Conformity2_3.Text = filling.AddQ(11);
            Conformity2_4.Text = filling.AddQ(12);
            OrderTwo.Clear();
            BuildOrderTwo(9, 13);
            a = 0;
            foreach (int i in OrderTwo)
            {
                mass[a++] = i;
            }
            Juxtapositon2_4.Text = filling.GetTrueAns(mass[0]);
            Juxtapositon2_1.Text = filling.GetTrueAns(mass[1]);
            Juxtapositon2_3.Text = filling.GetTrueAns(mass[2]);
            Juxtapositon2_2.Text = filling.GetTrueAns(mass[3]);
        }
        void BuildOrder(int a, int b)
        {
            while (Order.Count < 4)
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
        #region Button
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

        private void Juxtapositon1_1_Click(object sender, EventArgs e)
        {
            Juxtapositon1_1.BackColor = c1;
        }

        private void Juxtapositon1_2_Click(object sender, EventArgs e)
        {
            Juxtapositon1_2.BackColor = c1;
        }

        private void Juxtapositon1_3_Click(object sender, EventArgs e)
        {
            Juxtapositon1_3.BackColor = c1;
        }

        private void Juxtapositon1_4_Click(object sender, EventArgs e)
        {
            Juxtapositon1_4.BackColor = c1;
        }

        private void Juxtapositon2_1_Click(object sender, EventArgs e)
        {
            Juxtapositon2_1.BackColor = c2;
        }

        private void Juxtapositon2_2_Click(object sender, EventArgs e)
        {
            Juxtapositon2_2.BackColor = c2;
        }

        private void Juxtapositon2_3_Click(object sender, EventArgs e)
        {
            Juxtapositon2_3.BackColor = c2;
        }

        private void Juxtapositon2_4_Click(object sender, EventArgs e)
        {
            Juxtapositon2_4.BackColor = c2;
        }

        private void Conformity1_1_Click(object sender, EventArgs e)
        {
            c1 = Color.SeaGreen;
        }

        private void Conformity1_2_Click(object sender, EventArgs e)
        {
            c1 = Color.MediumSeaGreen;
        }

        private void Conformity1_3_Click(object sender, EventArgs e)
        {
            c1 = Color.Teal;
        }

        private void Conformity1_4_Click(object sender, EventArgs e)
        {
            c1 = Color.LightSeaGreen;
        }

        private void Conformity2_1_Click(object sender, EventArgs e)
        {
            c2 = Color.SeaGreen;
        }

        private void Conformity2_2_Click(object sender, EventArgs e)
        {
            c2 = Color.MediumSeaGreen;
        }

        private void Conformity2_3_Click(object sender, EventArgs e)
        {
            c2 = Color.Teal;
        }

        private void Conformity2_4_Click(object sender, EventArgs e)
        {
            c2 = Color.LightSeaGreen;
        }
        #endregion
        private void PutAnsLight()
        {
            if (Answer1_1.BackColor == Color.Teal)
            { AnswersClient.Add(Answer1_1.Text); }
            else if (Answer1_2.BackColor == Color.Teal)
            { AnswersClient.Add(Answer1_2.Text); }
            else if (Answer1_3.BackColor == Color.Teal)
            { AnswersClient.Add(Answer1_3.Text); }
            else if (Answer1_4.BackColor == Color.Teal)
            { AnswersClient.Add(Answer1_4.Text); }

            if (Answer2_1.BackColor == Color.Teal)
            { AnswersClient.Add(Answer2_1.Text); }
            else if (Answer2_2.BackColor == Color.Teal)
            { AnswersClient.Add(Answer2_2.Text); }
            else if (Answer2_3.BackColor == Color.Teal)
            { AnswersClient.Add(Answer2_3.Text); }
            else if (Answer2_4.BackColor == Color.Teal)
            { AnswersClient.Add(Answer2_4.Text); }

            if (Answer3_1.BackColor == Color.Teal)
            { AnswersClient.Add(Answer3_1.Text); }
            else if (Answer3_2.BackColor == Color.Teal)
            { AnswersClient.Add(Answer3_2.Text); }
            else if (Answer3_3.BackColor == Color.Teal)
            { AnswersClient.Add(Answer3_3.Text); }
            else if (Answer3_4.BackColor == Color.Teal)
            { AnswersClient.Add(Answer3_4.Text); }

            if (Answer4_1.BackColor == Color.Teal)
            { AnswersClient.Add(Answer4_1.Text); }
            else if (Answer4_2.BackColor == Color.Teal)
            { AnswersClient.Add(Answer4_2.Text); }
            else if (Answer4_3.BackColor == Color.Teal)
            { AnswersClient.Add(Answer4_3.Text); }
            else if (Answer4_4.BackColor == Color.Teal)
            { AnswersClient.Add(Answer4_4.Text); }

            if (Answer5_1.BackColor == Color.Teal)
            { AnswersClient.Add(Answer5_1.Text); }
            else if (Answer5_2.BackColor == Color.Teal)
            { AnswersClient.Add(Answer5_2.Text); }
            else if (Answer5_3.BackColor == Color.Teal)
            { AnswersClient.Add(Answer5_3.Text); }
            else if (Answer5_4.BackColor == Color.Teal)
            { AnswersClient.Add(Answer5_4.Text); }
        }
        private void PutAnsMiddle()
        {
            if(Juxtapositon1_1.BackColor== Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon1_1.Text); }
            else if (Juxtapositon1_2.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon1_2.Text); }
            else if (Juxtapositon1_3.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon1_3.Text); }
            else if (Juxtapositon1_4.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon1_4.Text); }

            if (Juxtapositon1_1.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon1_1.Text); }
            else if (Juxtapositon1_2.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon1_2.Text); }
            else if (Juxtapositon1_3.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon1_3.Text); }
            else if (Juxtapositon1_4.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon1_4.Text); }

            if (Juxtapositon1_1.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon1_1.Text); }
            else if (Juxtapositon1_2.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon1_2.Text); }
            else if (Juxtapositon1_3.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon1_3.Text); }
            else if (Juxtapositon1_4.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon1_4.Text); }

            if (Juxtapositon1_1.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon1_1.Text); }
            else if (Juxtapositon1_2.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon1_2.Text); }
            else if (Juxtapositon1_3.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon1_3.Text); }
            else if (Juxtapositon1_4.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon1_4.Text); }


            if (Juxtapositon2_1.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon2_1.Text); }
            else if (Juxtapositon2_2.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon2_2.Text); }
            else if (Juxtapositon2_3.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon2_3.Text); }
            else if (Juxtapositon2_4.BackColor == Color.SeaGreen)
            { AnswersClient.Add(Juxtapositon2_4.Text); }

            if (Juxtapositon2_1.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon2_1.Text); }
            else if (Juxtapositon2_2.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon2_2.Text); }
            else if (Juxtapositon2_3.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon2_3.Text); }
            else if (Juxtapositon2_4.BackColor == Color.MediumSeaGreen)
            { AnswersClient.Add(Juxtapositon2_4.Text); }

            if (Juxtapositon2_1.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon2_1.Text); }
            else if (Juxtapositon2_2.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon2_2.Text); }
            else if (Juxtapositon2_3.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon2_3.Text); }
            else if (Juxtapositon2_4.BackColor == Color.Teal)
            { AnswersClient.Add(Juxtapositon2_4.Text); }

            if (Juxtapositon2_1.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon2_1.Text); }
            else if (Juxtapositon2_2.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon2_2.Text); }
            else if (Juxtapositon2_3.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon2_3.Text); }
            else if (Juxtapositon2_4.BackColor == Color.LightSeaGreen)
            { AnswersClient.Add(Juxtapositon2_4.Text); }
        }
        private void LookTrueAns()
        {
            if (Answer1_1.Text == filling.GetTrueAns(0))
            { Answer1_1.BackColor = Color.Green; }
            else if (Answer1_2.Text == filling.GetTrueAns(0))
            { Answer1_2.BackColor = Color.Green; }
            else if (Answer1_3.Text == filling.GetTrueAns(0))
            { Answer1_3.BackColor = Color.Green; }
            else if (Answer1_4.Text == filling.GetTrueAns(0))
            { Answer1_4.BackColor = Color.Green; }

            if (Answer2_1.Text == filling.GetTrueAns(1))
            { Answer2_1.BackColor = Color.Green; }
            else if (Answer2_2.Text == filling.GetTrueAns(1))
            { Answer2_2.BackColor = Color.Green; }
            else if (Answer2_3.Text == filling.GetTrueAns(1))
            { Answer2_3.BackColor = Color.Green; }
            else if (Answer2_4.Text == filling.GetTrueAns(1))
            { Answer2_4.BackColor = Color.Green; }

            if (Answer3_1.Text == filling.GetTrueAns(2))
            { Answer3_1.BackColor = Color.Green; }
            else if (Answer3_2.Text == filling.GetTrueAns(2))
            { Answer3_2.BackColor = Color.Green; }
            else if (Answer3_3.Text == filling.GetTrueAns(2))
            { Answer3_3.BackColor = Color.Green; }
            else if (Answer3_4.Text == filling.GetTrueAns(2))
            { Answer3_4.BackColor = Color.Green; }

            if (Answer4_1.Text == filling.GetTrueAns(3))
            { Answer4_1.BackColor = Color.Green; }
            else if (Answer4_2.Text == filling.GetTrueAns(3))
            { Answer4_2.BackColor = Color.Green; }
            else if (Answer4_3.Text == filling.GetTrueAns(3))
            { Answer4_3.BackColor = Color.Green; }
            else if (Answer4_4.Text == filling.GetTrueAns(3))
            { Answer4_4.BackColor = Color.Green; }

            if (Answer5_1.Text == filling.GetTrueAns(4))
            { Answer5_1.BackColor = Color.Green; }
            else if (Answer5_2.Text == filling.GetTrueAns(4))
            { Answer5_2.BackColor = Color.Green; }
            else if (Answer5_3.Text == filling.GetTrueAns(4))
            { Answer5_3.BackColor = Color.Green; }
            else if (Answer5_4.Text == filling.GetTrueAns(4))
            { Answer5_4.BackColor = Color.Green; }

            if (Juxtapositon1_1.Text == filling.GetTrueAns(5))
            { Juxtapositon1_1.BackColor = Color.SeaGreen; }
            else if(Juxtapositon1_2.Text== filling.GetTrueAns(5))
            { Juxtapositon1_2.BackColor = Color.SeaGreen; }
            else if (Juxtapositon1_3.Text == filling.GetTrueAns(5))
            { Juxtapositon1_3.BackColor = Color.SeaGreen; }
            else if (Juxtapositon1_4.Text == filling.GetTrueAns(5))
            { Juxtapositon1_4.BackColor = Color.SeaGreen; }

            if (Juxtapositon1_1.Text == filling.GetTrueAns(6))
            { Juxtapositon1_1.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon1_2.Text == filling.GetTrueAns(6))
            { Juxtapositon1_2.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon1_3.Text == filling.GetTrueAns(6))
            { Juxtapositon1_3.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon1_4.Text == filling.GetTrueAns(6))
            { Juxtapositon1_4.BackColor = Color.MediumSeaGreen; }

            if (Juxtapositon1_1.Text == filling.GetTrueAns(7))
            { Juxtapositon1_1.BackColor = Color.Teal; }
            else if (Juxtapositon1_2.Text == filling.GetTrueAns(7))
            { Juxtapositon1_2.BackColor = Color.Teal; }
            else if (Juxtapositon1_3.Text == filling.GetTrueAns(7))
            { Juxtapositon1_3.BackColor = Color.Teal; }
            else if (Juxtapositon1_4.Text == filling.GetTrueAns(7))
            { Juxtapositon1_4.BackColor = Color.Teal; }
           
            if(Juxtapositon1_1.Text == filling.GetTrueAns(8))
            { Juxtapositon1_1.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon1_2.Text == filling.GetTrueAns(8))
            { Juxtapositon1_2.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon1_3.Text == filling.GetTrueAns(8))
            { Juxtapositon1_3.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon1_4.Text == filling.GetTrueAns(8))
            { Juxtapositon1_4.BackColor = Color.LightSeaGreen; }

            if (Juxtapositon2_1.Text == filling.GetTrueAns(9))
            { Juxtapositon2_1.BackColor = Color.SeaGreen; }
            else if (Juxtapositon2_2.Text == filling.GetTrueAns(9))
            { Juxtapositon2_2.BackColor = Color.SeaGreen; }
            else if (Juxtapositon2_3.Text == filling.GetTrueAns(9))
            { Juxtapositon2_3.BackColor = Color.SeaGreen; }
            else if (Juxtapositon2_4.Text == filling.GetTrueAns(9))
            { Juxtapositon2_4.BackColor = Color.SeaGreen; }

            if (Juxtapositon2_1.Text == filling.GetTrueAns(10))
            { Juxtapositon2_1.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon2_2.Text == filling.GetTrueAns(10))
            { Juxtapositon2_2.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon2_3.Text == filling.GetTrueAns(10))
            { Juxtapositon2_3.BackColor = Color.MediumSeaGreen; }
            else if (Juxtapositon2_4.Text == filling.GetTrueAns(10))
            { Juxtapositon2_4.BackColor = Color.MediumSeaGreen; }

            if (Juxtapositon2_1.Text == filling.GetTrueAns(11))
            { Juxtapositon2_1.BackColor = Color.Teal; }
            else if (Juxtapositon2_2.Text == filling.GetTrueAns(11))
            { Juxtapositon2_2.BackColor = Color.Teal; }
            else if (Juxtapositon2_3.Text == filling.GetTrueAns(11))
            { Juxtapositon2_3.BackColor = Color.Teal; }
            else if (Juxtapositon2_4.Text == filling.GetTrueAns(11))
            { Juxtapositon2_4.BackColor = Color.Teal; }

            if (Juxtapositon2_1.Text == filling.GetTrueAns(12))
            { Juxtapositon2_1.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon2_2.Text == filling.GetTrueAns(12))
            { Juxtapositon2_2.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon2_3.Text == filling.GetTrueAns(12))
            { Juxtapositon2_3.BackColor = Color.LightSeaGreen; }
            else if (Juxtapositon2_4.Text == filling.GetTrueAns(12))
            { Juxtapositon2_4.BackColor = Color.LightSeaGreen; }
        }
        private void Test_Click(object sender, EventArgs e)
        {
            PutAnsLight();
            PutAnsMiddle();
            if(AnswersClient.Count==13)
            {
                int result = 0;
                for (int i = 0; i < 13; i++)
                {
                    if (AnswersClient[i] == filling.GetTrueAns(i))
                    { result++; }
                }
                MessageBox.Show(
                          $"Правильных ответов: {result}",
                          "Результаты",
                          MessageBoxButtons.OK
                   );
                LookTrueAns();
                ResultTesting.PushSQL(result, AnswersClient.Count, "Средний");
            }
            else
            {
                MessageBox.Show(
                          "При прохождении теста была допущена ошибка!\n" +
                          "Проверте Ваши ответы",
                          "                                     Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information,
                          MessageBoxDefaultButton.Button1
                   );
            }
            AnswersClient.Clear();
        }
    }
}
