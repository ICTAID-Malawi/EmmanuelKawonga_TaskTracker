using System;
using System.Windows.Forms;
using TaskTracker.Classes;
using MySql.Data.MySqlClient;

namespace TaskTrackerApp
{
    public partial class TaskPage : Form
    {
        Tasks sometask = new Tasks();
        public TaskPage()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
           
        }
       
        //calls tasks data table or something
        private void View_the_tasks()
        {
            dataGridView1.DataSource = sometask.Fetch_tasks(new MySqlCommand("SELECT `TaskNumber`, `TaskName`,`Description`,`Status`,`StartDate`,`CompletionDate` FROM taskstable"));
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {
           View_the_tasks();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGrid = this.dataGridView1.Rows[e.RowIndex];
                label_id.Text = dataGrid.Cells[0].Value.ToString();
                Taskname_textbox.Text = dataGrid.Cells[1].Value.ToString();
                Desc_richTextBox.Text = dataGrid.Cells[2].Value.ToString();
                Status_comboBox.Text = dataGrid.Cells[3].Value.ToString();
                StartDate_Picker.Text = dataGrid.Cells[4].Value.ToString();
              //CompletionDate_Picker.Text = dataGrid.Cells[5].Value.ToString();
            }
        }
        //private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
        //    {
        //        DataGridViewRow dataGrid = this.dataGridView1.Rows[e.RowIndex];
        //        if (dataGrid.Cells.Count >= 6) // Ensure the row has at least 6 cells
        //        {
        //            label_id.Text = dataGrid.Cells[0].Value?.ToString() ?? "";
        //            Taskname_textbox.Text = dataGrid.Cells[1].Value?.ToString() ?? "";
        //            Desc_richTextBox.Text = dataGrid.Cells[2].Value?.ToString() ?? "";
        //            Status_comboBox.Text = dataGrid.Cells[3].Value?.ToString() ?? "";
        //            StartDate_Picker.Text = dataGrid.Cells[4].Value?.ToString() ?? "";
        //            CompletionDate_Picker.Text = dataGrid.Cells[5].Value?.ToString() ?? "";
        //        }
        //    }
        //}

        //private void Button_delete_Click(object sender, EventArgs e)
        //{
        //    int TaskNumber = int.Parse (label_id.Text);

        //    try 
        //    {
        //        if (sometask.Delete_task(TaskNumber))
        //        {
        //            MessageBox.Show("Task removed");
        //            View_the_tasks();
        //        }
        //    }
        //    catch(Exception ex) { MessageBox.Show("Something went wrong" + ex); }
        //}
        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(label_id.Text, out int TaskNumber))
            {
                try
                {
                    if (sometask.Delete_task(TaskNumber))
                    {
                        MessageBox.Show("Task removed");
                        View_the_tasks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid task number");
            }
        }


        private void alabel_id_Click(object sender, EventArgs e)
        {

        }

        private void Button_committ_Click(object sender, EventArgs e)
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
            DateTime CompletionDate = CompletionDate_Picker.Value.Date;

            try
            {
                if (sometask.Save_task(Taskname, Description, Status, StartDate, CompletionDate, User_id))
                {
                    MessageBox.Show("Your Task has been saved");
                    View_the_tasks();
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

        private void CompletionDate_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //string Taskname = Taskname_textbox.Text;
            //string Description = Desc_richTextBox.Text;
            //string Status = Status_comboBox.GetItemText(Status_comboBox.SelectedItem);
            //DateTime StartDate = StartDate_Picker.Value.Date;
            //DateTime CompletionDate = CompletionDate_Picker.Value.Date;

            //try
            //{
            //    // Assuming you have the task ID available
            //    int TaskNumber = selectedTaskID;

            //    if (sometask.Update_task(TaskNumber, Taskname, Description, Status, StartDate, CompletionDate))
            //    {
            //        MessageBox.Show("Your Task has been updated");
            //        View_the_tasks();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to update task");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }
    }
}
