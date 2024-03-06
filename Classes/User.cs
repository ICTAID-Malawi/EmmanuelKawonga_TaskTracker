using MySql.Data.MySqlClient;
using Npgsql;
using System;
using TaskTrackApp.Config;


namespace TaskTrackApp.Classes
{
    internal class User
    {   //Dbconn initialization------------------------------------------------
        Dbconn connection = new Dbconn();

        //handles user registration-------------------------------------------
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
        //checks for existing email-------------------------------------------
        public bool CheckExistingEmail(string Email) 
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_table` WHERE `Email` = '"+Email+"'",connection.GetMySqlConnection);

            connection.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnect();
            return count > 0;
        }
        //handles sign in-----------------------------------------------------
        //public bool SignIn(string Email, string Password) 
        //{
        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `users_table` WHERE `Email` = @email AND `Password` = @password", connection.GetMySqlConnection);

        //    command.Parameters.Add("@email",MySqlDbType.VarChar).Value = Email;
        //    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

        //    connection.openConnect();
        //    MySqlDataReader reader = command.ExecuteReader();
        //    bool success = reader.HasRows;
        //    reader.Close();
        //    connection.closeConnect();

        //    return success;
        //}

        //Recent changes if it breakes the problem is here

        //Validates user credentials-----------------------------------------
        public int ValidateUserCredentials(string Email, string Password)
        {
            int User_id = 0;

            MySqlCommand command = new MySqlCommand("SELECT User_id FROM users_table WHERE Email = @email AND Password = @password", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@password", Password);

            connection.openConnect();

            object result = command.ExecuteScalar();
            if (result != null)
                User_id = Convert.ToInt32(result);

            connection.closeConnect();

            return User_id;
        }
        //Generates a token for the user--------------------------------------
        public string GenerateToken(int User_id)
        {
            // token generation logic 
            return Guid.NewGuid().ToString();
        }
        //Inserts token into database-----------------------------------------
        public void InsertToken(int User_id, string Token)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO tokens (User_id, Token, ExpirationTime) VALUES (@userId, @token, @expirationTime)", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@userId", User_id);
            command.Parameters.AddWithValue("@token", Token);
            command.Parameters.AddWithValue("@expirationTime", DateTime.Now.AddHours(24));

            connection.openConnect();
            command.ExecuteNonQuery();
            connection.closeConnect();
        }
    }
}
