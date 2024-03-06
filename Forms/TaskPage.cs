using System;
using System.Windows.Forms;
using TaskTracker.Classes;
using WindowsFormsApp1.Forms;
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
            Taskentryform taskentryform = new Taskentryform();
            taskentryform.Show();
        }
        
       
        //calls tasks data table or something
        private void view_the_tasks()
        {
            dataGridView1.DataSource = sometask.fetch_tasks(new MySqlCommand("SELECT `TaskName`,`Description`,`Status`,`StartDate`,`CompletionDate` FROM taskstable"));
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {
           view_the_tasks();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = this.dataGridView1.Rows[e.RowIndex];

            }
        }
    }
}
