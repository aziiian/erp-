using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using ERP_1;

namespace ERP_1
{
    public partial class Form1 : Form
    {
        private Point? lastPoint;
        public Form1()
        {
            InitializeComponent();
            //Removing the windows title bar
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            //Cupture current positionwhen form is clicked 
            lastPoint = new Point(e.X, e.Y);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            //check if the mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                Point delta = new Point(e.X - lastPoint.Value.X, e.Y - lastPoint.Value.Y);
                //Update form position by adding the difference 
                Location = new Point(Location.X + delta.X, Location.Y + delta.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static class SessionManager
        {
            public static bool IsLoggenIn { get; private set; } = false;
            public static string CurrentUsername { get; private set; }
            public static bool IsLoggedIn { get; internal set; }

            public static void Login(string username)
            {
                IsLoggenIn = true;
                CurrentUsername = username;
            }

            public static void Logout()
            {
                IsLoggenIn = false;
                CurrentUsername = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server=127.0.0.1; user=root; database=erp_1; password=";
            string username = inuser.Text.Trim();
            string password = inpwd.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No Empty Fields Allowed");
                return;
            }

            using (var mySqlConnection = new MySqlConnection(conn))
            {
                try
                {
                    mySqlConnection.Open();
                    var query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    //using parametized querries
                    using (var mySqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("@username", username);
                        mySqlCommand.Parameters.AddWithValue("@password", password);

                        using (var reader = mySqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login Succesfull");
                                SessionManager.Login(username);
                                this.Hide();
                                DashForm dashForm = new DashForm();
                                dashForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Connection Error!" + ex.Message);
                }
            }
        }

        private void inpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}