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
using WindowsFormsApp1;

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

        private void button_login_Click(object sender, EventArgs e)
        {
            if(Email_textbox.Text =="" && Password_textbox.Text == "") 
            {
                MessageBox.Show("Please fill in the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string Email = Email_textbox.Text;
                    string Password = Password_textbox.Text;

                    if(useraction.SignIn(Email, Password))
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        LandingPage landingPage = new LandingPage();
                        landingPage.Show();
                    }
                    else { MessageBox.Show("Login Failed, check your credentials"); }
                }
                catch(Exception ex) { MessageBox.Show("Error" + ex); }
            }
        }

        //void loginformstyle() 
        //{
        //    Height = 450;
        //    Width = 729;
        //    FormBorderStyle = FormBorderStyle.None;
        //    BackColor = Color.White;
        //}
    }
}
