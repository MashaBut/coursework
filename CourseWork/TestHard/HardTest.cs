using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork.TestHard
{
    public partial class HardTest : Form
    {
        public HardTest()
        {
            InitializeComponent();
            Thread myThread = new Thread(new ThreadStart(BuiltQ));
            myThread.Start();
            BuiltAns();
        }
        Color[] color = { Color.Maroon, Color.Red, Color.Brown, Color.IndianRed, Color.OliveDrab, Color.DarkOliveGreen, Color.ForestGreen, Color.Green, Color.SeaGreen, Color.MediumSeaGreen, Color.Teal, Color.LightSeaGreen };
        Color c = Color.Maroon;
        static Random Random = new Random();
        FillingFormsHT formsHT = new FillingFormsHT();
        HashSet<int> Order = new HashSet<int>();
        ResultTesting ResultTesting = new ResultTesting();
        List<string> AnswersClient = new List<string>();
        private void BuiltQ()
        {
            Conformity1.Text = formsHT.AddQ(0);
            Conformity2.Text = formsHT.AddQ(1);
            Conformity3.Text = formsHT.AddQ(2);
            Conformity4.Text = formsHT.AddQ(3);
            Conformity5.Text = formsHT.AddQ(4);
            Conformity6.Text = formsHT.AddQ(5);
            Conformity7.Text = formsHT.AddQ(6);
            Conformity8.Text = formsHT.AddQ(7);
            Conformity9.Text = formsHT.AddQ(8);
            Conformity10.Text = formsHT.AddQ(9);
            Conformity11.Text = formsHT.AddQ(10);
            Conformity12.Text = formsHT.AddQ(11);
        }
        private void BuiltAns()
        {
            BuiltOrder(0, 30);
            int[] mass = new int[30];
            int a = 0;
            foreach(int i in Order)
            { mass[a++] = i; }
            Juxtapositon1.Text = formsHT.AddErrorAns(mass[0]);
            Juxtapositon2.Text = formsHT.AddErrorAns(mass[1]);
            Juxtapositon3.Text = formsHT.AddErrorAns(mass[2]);
            Juxtapositon4.Text = formsHT.AddErrorAns(mass[3]);
            Juxtapositon5.Text = formsHT.AddErrorAns(mass[4]);
            Juxtapositon6.Text = formsHT.AddErrorAns(mass[5]);
            Juxtapositon7.Text = formsHT.AddErrorAns(mass[6]);
            Juxtapositon8.Text = formsHT.AddErrorAns(mass[7]);
            Juxtapositon9.Text = formsHT.AddErrorAns(mass[8]);
            Juxtapositon10.Text = formsHT.AddErrorAns(mass[9]);

            Juxtapositon11.Text = formsHT.AddErrorAns(mass[10]);
            Juxtapositon12.Text = formsHT.AddErrorAns(mass[11]);
            Juxtapositon13.Text = formsHT.AddErrorAns(mass[12]);
            Juxtapositon14.Text = formsHT.AddErrorAns(mass[13]);
            Juxtapositon15.Text = formsHT.AddErrorAns(mass[14]);
            Juxtapositon16.Text = formsHT.AddErrorAns(mass[15]);
            Juxtapositon17.Text = formsHT.AddErrorAns(mass[16]);
            Juxtapositon18.Text = formsHT.AddErrorAns(mass[17]);
            Juxtapositon19.Text = formsHT.AddErrorAns(mass[18]);
            Juxtapositon20.Text = formsHT.AddErrorAns(mass[19]);

            Juxtapositon21.Text = formsHT.AddErrorAns(mass[20]);
            Juxtapositon22.Text = formsHT.AddErrorAns(mass[21]);
            Juxtapositon23.Text = formsHT.AddErrorAns(mass[22]);
            Juxtapositon24.Text = formsHT.AddErrorAns(mass[23]);
            Juxtapositon25.Text = formsHT.AddErrorAns(mass[24]);
            Juxtapositon26.Text = formsHT.AddErrorAns(mass[25]);
            Juxtapositon27.Text = formsHT.AddErrorAns(mass[26]);
            Juxtapositon28.Text = formsHT.AddErrorAns(mass[27]);
            Juxtapositon29.Text = formsHT.AddErrorAns(mass[28]);
            Juxtapositon30.Text = formsHT.AddErrorAns(mass[29]);
        }
        void BuiltOrder(int a, int b)
        {
            while (Order.Count < 30)
            {
                Order.Add(Random.Next(a, b));
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region ColorButton
        private void Conformity1_Click(object sender, EventArgs e)
        {
            c = Color.Maroon;
        }

        private void Conformity2_Click(object sender, EventArgs e)
        {
            c = Color.Red;
        }

        private void Conformity3_Click(object sender, EventArgs e)
        {
            c = Color.Brown;
        }

        private void Conformity4_Click(object sender, EventArgs e)
        {
            c = Color.IndianRed;
        }

        private void Conformity5_Click(object sender, EventArgs e)
        {
            c = Color.OliveDrab;
        }

        private void Conformity6_Click(object sender, EventArgs e)
        {
            c = Color.DarkOliveGreen;
        }

        private void Conformity7_Click(object sender, EventArgs e)
        {
            c = Color.ForestGreen;
        }

        private void Conformity8_Click(object sender, EventArgs e)
        {
            c = Color.Green;
        }

        private void Conformity9_Click(object sender, EventArgs e)
        {
            c = Color.SeaGreen;
        }

        private void Conformity10_Click(object sender, EventArgs e)
        {
            c = Color.MediumSeaGreen;
        }

        private void Conformity11_Click(object sender, EventArgs e)
        {
            c = Color.Teal;
        }

        private void Conformity12_Click(object sender, EventArgs e)
        {
            c = Color.LightSeaGreen;
        }

        private void Juxtapositon1_Click(object sender, EventArgs e)
        {
            Juxtapositon1.BackColor = c;
        }

        private void Juxtapositon2_Click(object sender, EventArgs e)
        {
            Juxtapositon2.BackColor = c;
        }

        private void Juxtapositon3_Click(object sender, EventArgs e)
        {
            Juxtapositon3.BackColor = c;
        }

        private void Juxtapositon4_Click(object sender, EventArgs e)
        {
            Juxtapositon4.BackColor = c;
        }

        private void Juxtapositon5_Click(object sender, EventArgs e)
        {
            Juxtapositon5.BackColor = c;
        }

        private void Juxtapositon6_Click(object sender, EventArgs e)
        {
            Juxtapositon6.BackColor = c;
        }

        private void Juxtapositon7_Click(object sender, EventArgs e)
        {
            Juxtapositon7.BackColor = c;
        }

        private void Juxtapositon8_Click(object sender, EventArgs e)
        {
            Juxtapositon8.BackColor = c;
        }

        private void Juxtapositon9_Click(object sender, EventArgs e)
        {
            Juxtapositon9.BackColor = c;
        }

        private void Juxtapositon10_Click(object sender, EventArgs e)
        {
            Juxtapositon10.BackColor = c;
        }

        private void Juxtapositon11_Click(object sender, EventArgs e)
        {
            Juxtapositon11.BackColor = c;
        }

        private void Juxtapositon12_Click(object sender, EventArgs e)
        {
            Juxtapositon12.BackColor = c;
        }

        private void Juxtapositon13_Click(object sender, EventArgs e)
        {
            Juxtapositon13.BackColor = c;
        }

        private void Juxtapositon14_Click(object sender, EventArgs e)
        {
            Juxtapositon14.BackColor = c;
        }

        private void Juxtapositon15_Click(object sender, EventArgs e)
        {
            Juxtapositon15.BackColor = c;
        }

        private void Juxtapositon16_Click(object sender, EventArgs e)
        {
            Juxtapositon16.BackColor = c;
        }

        private void Juxtapositon17_Click(object sender, EventArgs e)
        {
            Juxtapositon17.BackColor = c;
        }

        private void Juxtapositon18_Click(object sender, EventArgs e)
        {
            Juxtapositon18.BackColor = c;
        }

        private void Juxtapositon19_Click(object sender, EventArgs e)
        {
            Juxtapositon19.BackColor = c;
        }

        private void Juxtapositon20_Click(object sender, EventArgs e)
        {
            Juxtapositon20.BackColor = c;
        }

        private void Juxtapositon21_Click(object sender, EventArgs e)
        {
            Juxtapositon21.BackColor = c;
        }

        private void Juxtapositon22_Click(object sender, EventArgs e)
        {
            Juxtapositon22.BackColor = c;
        }

        private void Juxtapositon23_Click(object sender, EventArgs e)
        {
            Juxtapositon23.BackColor = c;
        }

        private void Juxtapositon24_Click(object sender, EventArgs e)
        {
            Juxtapositon24.BackColor = c;
        }

        private void Juxtapositon25_Click(object sender, EventArgs e)
        {
            Juxtapositon25.BackColor = c;
        }

        private void Juxtapositon26_Click(object sender, EventArgs e)
        {
            Juxtapositon26.BackColor = c;
        }

        private void Juxtapositon27_Click(object sender, EventArgs e)
        {
            Juxtapositon27.BackColor = c;
        }

        private void Juxtapositon28_Click(object sender, EventArgs e)
        {
            Juxtapositon28.BackColor = c;
        }

        private void Juxtapositon29_Click(object sender, EventArgs e)
        {
            Juxtapositon29.BackColor = c;
        }

        private void Juxtapositon30_Click(object sender, EventArgs e)
        {
            Juxtapositon30.BackColor = c;
        }
        #endregion
        private void Normal()
        {
            Juxtapositon1.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon2.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon3.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon4.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon5.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon6.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon7.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon8.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon9.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon10.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon11.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon12.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon13.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon14.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon15.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon16.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon17.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon18.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon19.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon20.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon21.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon22.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon23.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon24.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon25.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon26.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon27.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon28.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon29.BackColor = Color.FromArgb(0, 50, 50);
            Juxtapositon30.BackColor = Color.FromArgb(0, 50, 50);
        }
        private void TrueAns()
        {
            Normal();
            for (int i=0;i<12;i++)
            {
                TrueAns(color[i], i);
            }
        }
        private void TrueAns(Color c, int poz)
        {
            if (Juxtapositon1.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon1.BackColor = c; }
            else if (Juxtapositon2.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon2.BackColor = c; }
            else if (Juxtapositon3.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon3.BackColor = c; }
            else if (Juxtapositon4.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon4.BackColor = c; }
            else if (Juxtapositon5.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon5.BackColor = c; }
            else if (Juxtapositon6.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon6.BackColor = c; }
            else if (Juxtapositon7.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon7.BackColor = c; }
            else if (Juxtapositon8.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon8.BackColor = c; }
            else if (Juxtapositon9.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon9.BackColor = c; }
            else if (Juxtapositon10.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon10.BackColor = c; }
            else if (Juxtapositon11.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon11.BackColor = c; }
            else if (Juxtapositon12.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon12.BackColor = c; }
            else if (Juxtapositon13.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon13.BackColor = c; }
            else if (Juxtapositon14.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon14.BackColor = c; }
            else if (Juxtapositon15.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon15.BackColor = c; }
            else if (Juxtapositon16.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon16.BackColor = c; }
            else if (Juxtapositon17.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon17.BackColor = c; }
            else if (Juxtapositon18.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon18.BackColor = c; }
            else if (Juxtapositon19.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon19.BackColor = c; }
            else if (Juxtapositon20.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon20.BackColor = c; }
            else if (Juxtapositon21.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon21.BackColor = c; }
            else if (Juxtapositon22.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon22.BackColor = c; }
            else if (Juxtapositon23.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon23.BackColor = c; }
            else if (Juxtapositon24.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon24.BackColor = c; }
            else if (Juxtapositon25.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon25.BackColor = c; }
            else if (Juxtapositon26.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon26.BackColor = c; }
            else if (Juxtapositon27.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon27.BackColor = c; }
            else if (Juxtapositon28.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon28.BackColor = c; }
            else if (Juxtapositon29.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon29.BackColor = c; }
            else if (Juxtapositon30.Text == formsHT.GetTrueAns(poz))
            { Juxtapositon30.BackColor = c; }
        }
        private void ClickClient(Color c)
        {
            if(Juxtapositon1.BackColor==c)
            { AnswersClient.Add(Juxtapositon1.Text); }
            else if (Juxtapositon2.BackColor == c)
            { AnswersClient.Add(Juxtapositon2.Text); }
            else if (Juxtapositon3.BackColor == c)
            { AnswersClient.Add(Juxtapositon3.Text); }
            else if (Juxtapositon4.BackColor == c)
            { AnswersClient.Add(Juxtapositon4.Text); }
            else if (Juxtapositon5.BackColor == c)
            { AnswersClient.Add(Juxtapositon5.Text); }
            else if (Juxtapositon6.BackColor == c)
            { AnswersClient.Add(Juxtapositon6.Text); }
            else if (Juxtapositon7.BackColor == c)
            { AnswersClient.Add(Juxtapositon7.Text); }
            else if (Juxtapositon8.BackColor == c)
            { AnswersClient.Add(Juxtapositon8.Text); }
            else if (Juxtapositon9.BackColor == c)
            { AnswersClient.Add(Juxtapositon9.Text); }
            else if (Juxtapositon10.BackColor == c)
            { AnswersClient.Add(Juxtapositon10.Text); }
            else if (Juxtapositon11.BackColor == c)
            { AnswersClient.Add(Juxtapositon11.Text); }
            else if (Juxtapositon12.BackColor == c)
            { AnswersClient.Add(Juxtapositon12.Text); }
            else if (Juxtapositon13.BackColor == c)
            { AnswersClient.Add(Juxtapositon13.Text); }
            else if (Juxtapositon14.BackColor == c)
            { AnswersClient.Add(Juxtapositon14.Text); }
            else if (Juxtapositon15.BackColor == c)
            { AnswersClient.Add(Juxtapositon15.Text); }
            else if (Juxtapositon16.BackColor == c)
            { AnswersClient.Add(Juxtapositon16.Text); }
            else if (Juxtapositon17.BackColor == c)
            { AnswersClient.Add(Juxtapositon17.Text); }
            else if (Juxtapositon18.BackColor == c)
            { AnswersClient.Add(Juxtapositon18.Text); }
            else if (Juxtapositon19.BackColor == c)
            { AnswersClient.Add(Juxtapositon19.Text); }
            else if (Juxtapositon20.BackColor == c)
            { AnswersClient.Add(Juxtapositon20.Text); }
            else if (Juxtapositon21.BackColor == c)
            { AnswersClient.Add(Juxtapositon21.Text); }
            else if (Juxtapositon22.BackColor == c)
            { AnswersClient.Add(Juxtapositon22.Text); }
            else if (Juxtapositon23.BackColor == c)
            { AnswersClient.Add(Juxtapositon23.Text); }
            else if (Juxtapositon24.BackColor == c)
            { AnswersClient.Add(Juxtapositon24.Text); }
            else if (Juxtapositon25.BackColor == c)
            { AnswersClient.Add(Juxtapositon25.Text); }
            else if (Juxtapositon26.BackColor == c)
            { AnswersClient.Add(Juxtapositon26.Text); }
            else if (Juxtapositon27.BackColor == c)
            { AnswersClient.Add(Juxtapositon27.Text); }
            else if (Juxtapositon28.BackColor == c)
            { AnswersClient.Add(Juxtapositon28.Text); }
            else if (Juxtapositon29.BackColor == c)
            { AnswersClient.Add(Juxtapositon29.Text); }
            else if (Juxtapositon30.BackColor == c)
            { AnswersClient.Add(Juxtapositon30.Text); }
        }
        private void Test_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            { ClickClient(color[i]); }
            if(AnswersClient.Count==12)
            {
                int rez = 0;
                for(int i = 0;i < 12;i++)
                { if (AnswersClient[i] == formsHT.GetTrueAns(i))
                    { rez++; }
                }
                MessageBox.Show(
                         $"Правильных ответов: {rez}",
                         "Результаты",
                         MessageBoxButtons.OK
                  );
                ResultTesting.PushSQL(rez, AnswersClient.Count, "Сложный");
                TrueAns();
            }
            else
            {
                MessageBox.Show(
                           "Вы должны ответить на все вопросы!\n",
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
