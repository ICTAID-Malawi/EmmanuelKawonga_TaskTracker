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
namespace WindowsFormsApp1.Forms
{
    
    public partial class VerificationForm : Form
    {
        User useractions = new User();

        private string userEmail;
        private string verificationCode;

        public VerificationForm()
        {
            InitializeComponent();
        }

        private void textBox_verify_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button_verify_Click(object sender, EventArgs e)
        //{
        //    string enteredCode = textBox_verify.Text.Trim();

        //    if (enteredCode == verificationCode)
        //    {
        //        // Verification successful
        //        MessageBox.Show("Verification successful! You can now proceed with the registration.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Close the verification form
        //        this.Close();
        //    }
        //    else
        //    {
        //        // Verification failed
        //        MessageBox.Show("Incorrect verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void SetUserDetails(string email, string code)
        //{
        //    userEmail = email;
        //    verificationCode = code;

        //}
        private void button_verify_Click(object sender, EventArgs e)
        {
            string enteredCode = textBox_verify.Text.Trim();
            string userEmail = "ungwerukawonga@gmail.com"; // Retrieve the user's email

            if (useractions.ValidateVerificationCode(userEmail, enteredCode))
            {
                // Verification successful
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the verification form
                this.Close();
            }
            else
            {
                // Verification failed
                MessageBox.Show("Incorrect verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
