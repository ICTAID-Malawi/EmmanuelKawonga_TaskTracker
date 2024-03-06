using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TaskTrackApp.Config;


namespace TaskTracker.Classes
{
    internal class Tasks
    {   //calls connection
        Dbconn connection = new Dbconn();

        //method used to save tasks
        public bool Save_task(string Taskname, string Description, string Status, string StartDate, string CompleteDate)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO taskstable (`TaskName`,`Description`,`Status`,`StartDate`,`CompletionDate`) VALUES(@taskname,@description,@status,@startdate,@completiondate)");
            command.Parameters.Add("@taskname",MySqlDbType.VarChar).Value = Taskname;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
            command.Parameters.Add("@startdate", MySqlDbType.VarChar).Value = StartDate;
            command.Parameters.Add("@completiondate", MySqlDbType.VarChar).Value = CompleteDate;
            connection.openConnect();
            if(command.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else { connection.closeConnect();return false; }
        }
    }
}
