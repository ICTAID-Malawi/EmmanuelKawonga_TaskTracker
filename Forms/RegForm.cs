﻿using System;
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
using System.Diagnostics.Eventing.Reader;
using WindowsFormsApp1.Forms;

namespace TaskTracker
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

        private void Button_exit_Click(object sender, EventArgs e)
        {
            //closes window
            Application.Exit();
        }


        //private void Button_register_Click(object sender, EventArgs e)
        //{
        //    //an array of tuples to hold the textbox reference and the corresponding field name
        //    var textBoxesToCheck = new (TextBox textbox, string fieldName)[]
        //    {
        //      (Fname_textbox, "Firstname"),(Lname_textbox, "Lastname"),(Email_textbox, "Email"),(Password_textbox, "Password")
        //    };

        //    foreach (var (textbox, fieldName) in textBoxesToCheck)
        //    {
        //        if (string.IsNullOrWhiteSpace(textbox.Text))
        //        {
        //            MessageBox.Show($"Please fill in the {fieldName} field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //    }
        //    if (useractions.CheckExistingEmail(Email_textbox.Text))
        //    {
        //        //checks email text field 
        //        MessageBox.Show("Email already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Check if password meets requirements
        //    dynamic special = new Regex(@"[!@#$^&*]+");
        //    dynamic lowercase = new Regex(@"[a-z]+");
        //    dynamic uppercase = new Regex(@"[A-Z]+");
        //    dynamic number = new Regex(@"[0-9]+");

        //    if (!special.IsMatch(Password_textbox.Text) || !lowercase.IsMatch(Password_textbox.Text) || !uppercase.IsMatch(Password_textbox.Text) || !number.IsMatch(Password_textbox.Text))
        //    {
        //        MessageBox.Show("Please make sure your password is a combination of characters and symbols", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Attempt registration
        //    try
        //    {
        //        string Firstname = Fname_textbox.Text;
        //        string Lastname = Lname_textbox.Text;
        //        string Email = Email_textbox.Text;
        //        string Password = Password_textbox.Text;

        //        if (useractions.Registration(Firstname, Lastname, Email, Password))
        //        {
        //            MessageBox.Show("Registration successful");
        //            this.Hide();
        //            LoginForm loginForm = new LoginForm();
        //            loginForm.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Registration failed");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //nonsense 

        private void Button_register_Click(object sender, EventArgs e)
        {
            // Validate form inputs
            var textBoxesToCheck = new (TextBox textbox, string fieldName)[]
            {
        (Fname_textbox, "Firstname"),(Lname_textbox, "Lastname"),(Email_textbox, "Email"),(Password_textbox, "Password")
            };

            foreach (var (textbox, fieldName) in textBoxesToCheck)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show($"Please fill in the {fieldName} field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Check if email already exists
            if (useractions.CheckExistingEmail(Email_textbox.Text))
            {
                MessageBox.Show("Email already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if password meets requirements
            dynamic special = new Regex(@"[!@#$^&*]+");
            dynamic lowercase = new Regex(@"[a-z]+");
            dynamic uppercase = new Regex(@"[A-Z]+");
            dynamic number = new Regex(@"[0-9]+");

            if (!special.IsMatch(Password_textbox.Text) || !lowercase.IsMatch(Password_textbox.Text) || !uppercase.IsMatch(Password_textbox.Text) || !number.IsMatch(Password_textbox.Text))
            {
                MessageBox.Show("Please make sure your password is a combination of characters and symbols", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt registration
            //try
            //{
            //    string Firstname = Fname_textbox.Text;
            //    string Lastname = Lname_textbox.Text;
            //    string Email = Email_textbox.Text;
            //    string Password = Password_textbox.Text;

            //    // Register user
            //    if (useractions.Registration(Firstname, Lastname, Email, Password))
            //    {
            //        MessageBox.Show("Registration successful. Please check your email for the verification code.");

            //        // Send verification email
            //        useractions.SendVerificationEmail(Email);

            //        // Show verification form
            //        VerificationForm verificationForm = new VerificationForm();
            //        string verificationCode = useractions.GenerateAndSaveCode(); // You need to generate the verification code here
            //        verificationForm.SetUserDetails(Email_textbox.Text, verificationCode); // Pass user email and verification code
            //        verificationForm.Show();

            //        this.Hide(); // Hide the registration form
            //        LoginForm loginForm = new LoginForm();
            //        loginForm.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Registration failed");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                string Firstname = Fname_textbox.Text;
                string Lastname = Lname_textbox.Text;
                string Email = Email_textbox.Text;
                string Password = Password_textbox.Text;

                // Register user
                if (useractions.Registration(Firstname, Lastname, Email, Password))
                {
                    MessageBox.Show("Registration successful. Please check your email for the verification code.");

                    // Send verification email
                    useractions.SendVerificationEmail(Email);

                    // Generate and save verification code
                    string verificationCode = useractions.GenerateAndSaveCode(Email);

                    // Show verification form
                    VerificationForm verificationForm = new VerificationForm();
                    //verificationForm.SetUserDetails(Email_textbox.Text, verificationCode); // If unnecessary, remove this line
                    verificationForm.Show();

                    this.Hide(); // Hide the registration form
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Fname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
