using MySql.Data.MySqlClient;

namespace CourseWork
{
class CheckInClient : CheckIn
{
    string selectLogin, selectPassword;
    string insert;
    public string rezLogin, rezPassword;
    public bool finish1 = true, finish2 = true;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CheckInClient
            // 
            this.ClientSize = new System.Drawing.Size(212, 297);
            this.Name = "CheckInClient";
            this.Text = "TestHub";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
 
    public CheckInClient(string Name, string Username, string Login, string Password)
    {
        if (Name != null || Username != null || Login != null || Password != null)
        {
            string connStr = "server=localhost;user=root;database=coursework;password=mashutkabut99@gmail.com;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open(); 
                
            selectLogin = $"select distinct Login from coursework.client where Login='{Login}'";
            MySqlCommand commandLogin = new MySqlCommand(selectLogin, conn);
            try
            {
                rezLogin = commandLogin.ExecuteScalar().ToString();
                if (rezLogin == null)
                { finish1 = true; }
                else
                { finish1 = false; }
            }
            catch { }

            selectPassword = $"select distinct Password from coursework.client where Password='{Password}'";
            MySqlCommand commandPassword = new MySqlCommand(selectPassword, conn);
            try
            { rezPassword = commandPassword.ExecuteScalar().ToString();
                if (rezPassword == null)
                { finish2 = true; }
                else
                { finish2 = false; }
            }
            catch { }

            if (finish1 && finish2)
            {
                insert = $"insert coursework.client(Name,Usename,Login,Password) values ('{Name}','{Username}','{Login}','{Password}')";
                MySqlCommand command = new MySqlCommand(insert, conn);
                command.ExecuteNonQuery();
                LOG.LOGIN = Login;
            }
            conn.Close();
        }
    }
}
}
