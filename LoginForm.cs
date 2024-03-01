using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TaskTrackerApp
{
    public partial class LoginForm : Form
    {
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
            //to landing page
            new LandingPage().Show();
            this.Hide();
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
