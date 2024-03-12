using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTrackApp.Classes;
using TaskTracker.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TaskTrackerApp
{
    public partial class LandingPage : Form
    {
        User userprofile = new User();
        public LandingPage()
        {
            InitializeComponent();
        }

        private void loadforms(object form) 
        {
            //hide existing controls on the panel 
            HidePanelContent();
            //Remove any existing control from panel
            if(this.mainpanel.Controls.Count>0) this.mainpanel.Controls.RemoveAt(0);
            Form LandingPage = form as Form;
            LandingPage.TopLevel = false;
            LandingPage.Dock = DockStyle.Fill;

            this.mainpanel.Controls.Add(LandingPage);
            this.mainpanel.Tag = LandingPage;
            LandingPage.Show();
        }
        private void HidePanelContent()
        {
            //Hides each control with the panel
            foreach (Control control in this.mainpanel.Controls)
            control.Hide(); 
        }

        private void to_home_button_Click(object sender, EventArgs e)
        {
            new LandingPage().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void to_tasks_button_Click(object sender, EventArgs e)
        {
            loadforms(new TaskPage());
        }

        private void to_activites_button_Click(object sender, EventArgs e)
        {
            loadforms(new ActivitiyPage());
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            //Get the currrent date
            DateTime currentDate = DateTime.Now;

            //Format date as Month/Day
            string formattedDate = currentDate.ToString("MMMM / dd");

            //Display the formatted date in the label
            label_date.Text = formattedDate;
        }

        private void label_date_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            string Email = ""; // Store the email retrieved from GetUserProfile method
            try
            {
                // Call GetUserProfile method to get the user profile data
                DataTable profile = userprofile.GetUserProfile(Email);

                // Check if there is a result
                if (profile.Rows.Count > 0)
                {
                    // Get the email from the first row of the DataTable
                    Email = profile.Rows[0]["Email"].ToString();

                    // Set the email to the label label_user_profile
                    label_user.Text = Email;
                }
                else
                {
                    MessageBox.Show("Email not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }
    }
}
