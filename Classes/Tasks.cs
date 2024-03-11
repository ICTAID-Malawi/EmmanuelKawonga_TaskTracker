using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TaskTrackApp.Classes;
using TaskTrackApp.Config;


namespace TaskTracker.Classes
{
    internal class Tasks
    {   //calls connection
        Dbconn connection = new Dbconn();

        //method used to save tasks
        public bool Save_task(string Taskname, string Description, string Status, DateTime StartDate, DateTime CompletionDate, int User_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO taskstable (`Taskname`,`Description`,`Status`,`StartDate`,`CompletionDate`,`User_id`) VALUES(@taskname,@description,@status,@startdate,@completiondate,@userid)",connection.GetMySqlConnection);
            command.Parameters.Add("@taskname",MySqlDbType.VarChar).Value = Taskname;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
            command.Parameters.Add("@startdate", MySqlDbType.DateTime).Value = StartDate;
            command.Parameters.Add("@completiondate", MySqlDbType.DateTime).Value = CompletionDate;
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = User_id;

            connection.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else { connection.closeConnect(); return false; }
        }
        //method to update tasks
        public bool Update_task( int TaskNumber, string Taskname, string Description, string Status, DateTime StartDate, DateTime CompletionDate, int User_id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE taskstable SET TaskName = @taskname, Description = @description, Status = @status, StartDate = @startdate, CompletionDate = @completiondate WHERE TaskNumber = @tasknumber", connection.GetMySqlConnection);
            command.Parameters.Add("@tasknumber",MySqlDbType.Int32).Value = TaskNumber;
            command.Parameters.Add("@taskname", MySqlDbType.VarChar).Value = Taskname;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
            command.Parameters.Add("@startdate", MySqlDbType.DateTime).Value = StartDate;
            command.Parameters.Add("@completiondate", MySqlDbType.DateTime).Value = CompletionDate;
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = User_id;

            connection.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else { connection.closeConnect(); return false; }
        }

        //method to delete tasks
        public bool Delete_task(int TaskNumber)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `taskstable` WHERE TaskNumber = @tasknumber", connection.GetMySqlConnection);
            command.Parameters.Add("@tasknumber",MySqlDbType.Int32).Value=TaskNumber;
            
            connection.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else { connection.closeConnect(); return false; }
        }

        //fetch tasks
        public DataTable Fetch_tasks(MySqlCommand command)
        {
            try
            {
                command.Connection = connection.GetMySqlConnection;
                MySqlDataAdapter Adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                Adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
