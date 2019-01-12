using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        { Application.Exit(); }

        public void CloseForm_Click(object sender, EventArgs e)
        {
            InfoClient.Text = "Выполняется запрос...";
            PutClient client = new PutClient(NameClient.Text, PasswordClient.Text);
            if (client.rez == PasswordClient.Text)
            {
               LOG.LOGIN = NameClient.Text;
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
       
        private void Form1_Load(object sender, EventArgs e)
        {
           this.Region = new Region(Rec.RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 20));
        }
        public class Rec
        {
            public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
            {
                var diameter = radius * 2;
                var sz = new Size(diameter, diameter);
                var arc = new Rectangle(baseRect.Location, sz);
                var path = new GraphicsPath();

                // Верхний левый угол
                path.AddArc(arc, 180, 90);

                // Верхний правый угол
                arc.X = baseRect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // Нижний правый угол
                arc.Y = baseRect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // Нижний левый угол
                arc.X = baseRect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }
        }
    }
}
