using Npgsql;
using System;
using MySql.Data.MySqlClient;

namespace TaskTrackApp.Config
{
    //internal class Dbconn
    //{
    ////    // Connection to Postgres database
    ////    NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; username=postgres; Password=123$; Database=TaskTracker1_");

    ////    // Gets connection 
    ////    public NpgsqlConnection GetNpgsqlConnection { get { return connect; } }

    ////    // Opens connection if closed
    ////    public void OpenConnection()
    ////    {
    ////        try
    ////        {
    ////            connect.Open();
    ////            Console.WriteLine("Connected to PostgreSQL!");
    ////        }
    ////        catch (Exception ex)
    ////        {
    ////            Console.WriteLine($"Error: {ex.Message}");
    ////        }
    ////    }

    ////    // Closes connection if open
    ////    public void CloseConnection()
    ////    {
    ////        try
    ////        {
    ////            connect.Close();
    ////        }
    ////        catch (Exception ex)
    ////        {
    ////            Console.WriteLine($"Error: {ex.Message}");
    ////        }
    ////    }
    //}

    internal class Dbconn
    {
        //Connection to MySQL database 
        MySqlConnection connect = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =; database = tasktracker");


        // Gets connection 
        public MySqlConnection GetMySqlConnection { get { return connect; } }

        // opens the connection
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        // closes the connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

    }
}
