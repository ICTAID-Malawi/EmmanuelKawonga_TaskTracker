using MySql.Data.MySqlClient;
using Npgsql;
using System;
using TaskTrackApp.Config;


namespace TaskTrackApp.Classes
{
    internal class User
    {   //Dbconn initialization
        Dbconn connection = new Dbconn();

        //handles user registration
        public bool Registration(string Firstname, string Lastname, string Email, string Password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO users_table (`Firstname`,`Lastname`,`Email`,`Password`) VALUES(@firstname,@lastname,@email,@password)", connection.GetMySqlConnection);

            command.Parameters.Add("@firstname",MySqlDbType.VarChar).Value = Firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = Lastname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

            connection.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else { connection.closeConnect(); return false; }
        }
        //checks for existing email
        public bool CheckExistingEmail(string Email) 
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_table` WHERE `Email` = '"+Email+"'",connection.GetMySqlConnection);

            connection.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnect();
            return count > 0;
        }
        //handles sign in
        public bool SignIn(string Email, string Password) 
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_table` WHERE `Email` = @email AND `Password` = @password", connection.GetMySqlConnection);

            command.Parameters.Add("@email",MySqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

            connection.openConnect();
            MySqlDataReader reader = command.ExecuteReader();
            bool success = reader.HasRows;
            reader.Close();
            connection.closeConnect();

            return success;
        }

    }
}
