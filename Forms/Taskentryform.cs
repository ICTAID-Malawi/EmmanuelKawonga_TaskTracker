using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class Taskentryform : Form
    {
        //calls tasks class
        Tasks tasks = new Tasks();
        public Taskentryform()
        {
            InitializeComponent();
        }

        //private void button_commit_Click(object sender, EventArgs e)
        //{
        //    //submits all information
        //    if(Taskname_textbox.Text == "" && Desc_richTextBox.Text =="" && Status_comboBox.Text =="")
        //    {
        //        MessageBox.Show("Please fill the fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        string Taskname  = Taskname_textbox.Text;
        //        string Description = Desc_richTextBox.Text;
        //        string Status = Status_comboBox.GetItemText(Status_comboBox.SelectedItem);
        //        DateTime StartDate = StartDate_Picker.Value.Date;
        //        DateTime CompleteDate = CompletionDate_Picker.Value.Date;
        //        try
        //        {
        //            if(tasks.Save_task(Taskname,Description,Status,StartDate, CompleteDate))
        //            {
        //                MessageBox.Show("Your Task has been saved");
        //            }
        //        }
        //        catch (Exception ex) { MessageBox.Show("Error" + ex); }
        //    }
        //}

        //if it breaks its here 
        private void button_commit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Taskname_textbox.Text) || string.IsNullOrWhiteSpace(Desc_richTextBox.Text) || string.IsNullOrWhiteSpace(Status_comboBox.Text))
            {
                MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming you have the UserID available in your form
            int User_id = 1; // Replace with actual UserID

            string Taskname = Taskname_textbox.Text;
            string Description = Desc_richTextBox.Text;
            string Status = Status_comboBox.GetItemText(Status_comboBox.SelectedItem);
            DateTime StartDate = StartDate_Picker.Value.Date;
            DateTime CompleteDate = CompletionDate_Picker.Value.Date;

            try
            {
                if (tasks.Save_task(Taskname, Description, Status, StartDate, CompleteDate, User_id))
                {
                    MessageBox.Show("Your Task has been saved");
                }
                else
                {
                    MessageBox.Show("Failed to save task");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
