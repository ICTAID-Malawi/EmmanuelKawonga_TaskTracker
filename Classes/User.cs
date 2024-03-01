using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrackApp.Config;


namespace TaskTrackApp.Classes
{
    internal class User
    {   //Dbconn initialization
        Dbconn connection = new Dbconn();

        //handles user registration
        public bool Registration(string email, string password)
        {
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO users_table (email,password) VALUES(@email, @password)", connection.GetNpgsqlConnection);


            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            connection.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }



    }
}
