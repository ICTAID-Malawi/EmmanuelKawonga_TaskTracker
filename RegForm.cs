using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TaskTrackApp.Classes;
using TaskTrackerApp;

namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        //initializes user class
        User useractions = new User();
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //closes window
            Application.Exit();
        }


        private void button_register_Click(object sender, EventArgs e)
        {
            //validates textboxes entries before submitting to the database

            if (Email_textbox.Text == "") { MessageBox.Show("Please fill in the email field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            if (Password_textbox.Text == "") { MessageBox.Show("Please fill in the password field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            else
            {
                //checks if your password is a combination of various characters
                dynamic special = new Regex(@"[!@#$^&*]+");
                dynamic lowercase = new Regex(@"[a-z]+");
                dynamic uppercase = new Regex(@"[A-Z]+");
                dynamic number = new Regex(@"[0-9]+");

                if (!special.IsMatch(Password_textbox.Text) || !lowercase.IsMatch(Password_textbox.Text) || !uppercase.IsMatch(Password_textbox.Text) || !number.IsMatch(Password_textbox.Text))
                {
                    MessageBox.Show("Please make sure your password is a combination of characters and symbols", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //attempt registration
            try
            {
                string email = Email_textbox.Text;
                string password = Password_textbox.Text;

                if (useractions.Registration(email, password))
                {
                    MessageBox.Show("Registration successful");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else { MessageBox.Show("Registration failed"); }
            }
            catch (Exception ex)
            {
                { MessageBox.Show("Error" + ex); }
            }


            //new LoginForm().Show();
            //this.Hide();
        }
    }
}
