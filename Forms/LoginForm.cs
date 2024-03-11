using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTrackApp.Classes;
using TaskTracker;

namespace TaskTrackerApp
{
    public partial class LoginForm : Form
    {
        User useraction = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //loginformstyle();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //closes window
            Application.Exit();
        }

        private void labelreglink_Click(object sender, EventArgs e)
        {
            new RegForm().Show();
            this.Hide();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            
        }

        //private void button_login_Click(object sender, EventArgs e)
        //{
        //    if(Email_textbox.Text =="" && Password_textbox.Text == "") 
        //    {
        //        MessageBox.Show("Please fill in the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string Email = Email_textbox.Text;
        //            string Password = Password_textbox.Text;

        //            if(useraction.SignIn(Email, Password))
        //            {
        //                MessageBox.Show("Login Successful");
        //                this.Hide();
        //                LandingPage landingPage = new LandingPage();
        //                landingPage.Show();
        //            }
        //            else { MessageBox.Show("Login Failed, check your credentials"); }
        //        }
        //        catch(Exception ex) { MessageBox.Show("Error" + ex); }
        //    }
        //}



        //if it breaks its this part
        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email_textbox.Text) || string.IsNullOrWhiteSpace(Password_textbox.Text))
            {
                MessageBox.Show("Please fill in the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string Email = Email_textbox.Text;
                string Password = Password_textbox.Text;

                // Check user credentials and obtain UserID
                int User_id = useraction.ValidateUserCredentials(Email, Password);

                if (User_id > 0)
                {
                    // Generate token
                    string Token = useraction.GenerateToken(User_id);

                    // Insert token into tokens table
                    useraction.InsertToken(User_id, Token);

                    MessageBox.Show("Login Successful");
                    this.Hide();
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed, check your credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
