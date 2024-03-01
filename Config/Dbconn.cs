using Npgsql;
using System;

namespace TaskTrackApp.Config
{
    internal class Dbconn
    {
        // Connection to Postgres database
        NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; username=postgres; Password=123$; Database=TaskTracker1_");

        // Gets connection 
        public NpgsqlConnection GetNpgsqlConnection { get { return connect; } }

        // Opens connection if closed
        public void OpenConnection()
        {
            try
            {
                connect.Open();
                Console.WriteLine("Connected to PostgreSQL!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Closes connection if open
        public void CloseConnection()
        {
            try
            {
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
