using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_1;
using MySql.Data.MySqlClient;

namespace ERP_1
{
    public partial class DashForm : Form
    {
        private Point? lastPoint;
        public DashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += Form1_MouseDown;

            //set dashform as MDI container
            this.IsMdiContainer = true;

            //auto mouse click event on lblusername
            //problem on the lblusername not initializing automatically hence this fix
            lblusername.MouseClick += Lblusername_MouseClick;
        }

        private void Lblusername_MouseClick(object sender, MouseEventArgs e)
        {
            username(sender, e);//call the username method when button is clicked 
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
            //Log out from application
            Form1.SessionManager.Logout();
            this.Close();//Close Dash

            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void DashForm_Load(object sender, EventArgs e)
        {
            if (!Form1.SessionManager.IsLoggedIn)
            {
                MessageBox.Show("You are Logged in.");
                this.Close();

                Form1 loginForm = new Form1();
                loginForm.Show();
            }
            else
            {
                this.Text = "Dashboard - Welcome" + Form1.SessionManager.CurrentUsername;
                username(null, EventArgs.Empty);//call username method
            }
        }

        private void username(object sender, EventArgs e)
        {
            //Retrieve the name of the current user from the databse 
            string currentUsername = Form1.SessionManager.CurrentUsername;
            string name = GetUserName(currentUsername);

            //Display the name in the lblusername label
            lblusername.Text = "User: " + name + "";
        }

        //Fetching the customer name
        private string GetUserName(string username)
        {
            string name = "";

            //establish connection
            string connstring = "server=127.0.0.1; user=root; database=erp_1; password=";
            string query = "SELECT name FROM users WHERE username = @username";

            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //add parameters 
                    cmd.Parameters.AddWithValue("@username", username);
                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            name = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("User Invalid!");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return name; //Show the name retrieved from the database
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
            {
                //remove existing panels
                panel2.Controls.RemoveAt(0);
            }

            //create an instance of the Usercreation Form
            UserCreation userCreation = new UserCreation();

            //set priority
            userCreation.TopLevel = true;
            userCreation.FormBorderStyle = FormBorderStyle.None;
            userCreation.MdiParent = this;//set dashForm as parent

            //set form to mach size of panel
            userCreation.Size = panel2.Size;

            //add form to the controls collection of the panel
            panel2.Controls.Add(userCreation);
            userCreation.Show();
        }
    }
}
