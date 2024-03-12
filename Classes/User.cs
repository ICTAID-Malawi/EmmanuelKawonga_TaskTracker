using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Data;
using System.Net.Mail;
using TaskTrackApp.Config;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;



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
        //Get token
        public string GetToken(int User_id)
        {
            MySqlCommand command = new MySqlCommand("SELECT Token FROM Tokens WHERE User_id = @userid", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@userid", User_id);

            connection.openConnect();
            string token = command.ExecuteScalar()?.ToString(); // ExecuteScalar is used assuming there's only one token per user
            connection.closeConnect();

            return token;
        }
        //more nonsense

        public bool ValidateToken(int User_id, string token)
        {
            // Query the database to check if the token is valid for the given user
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Tokens WHERE User_id = @userId AND Token = @token", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@userId", User_id);
            command.Parameters.AddWithValue("@token", token);

            connection.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnect();

            return count > 0;
        }


        //-------------------------------------------------------------------
        //Get profile
        public DataTable GetUserProfile(string Email)
        {
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT Email FROM users_table", connection.GetMySqlConnection);

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value =Email;

            MySqlDataAdapter Adapter = new MySqlDataAdapter(command);
            DataTable profile = new DataTable();

            connection.openConnect();
            Adapter.Fill(profile);
            connection.closeConnect();

            return profile;
        }
        // generate random code
        // Generate and save random 5-digit code
        public string GenerateAndSaveCode(string userEmail)
        {
            // Generate random 5-digit code
            Random random = new Random();
            int Code = random.Next(10000, 99999);

            // Save code to database
            MySqlCommand command = new MySqlCommand("INSERT INTO codes (Code,Email) VALUES (@code,@email)", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@code", Code);
            command.Parameters.AddWithValue("@email", userEmail);

            connection.openConnect();
            command.ExecuteNonQuery();
            connection.closeConnect();

            //return the generate code
            return Code.ToString();
        }
       //The real nonsense 
        public void SendVerificationEmail(string userEmail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Emmanuel Kawonga", "kawongaemmanuel3@gmail.com"));
            message.To.Add(new MailboxAddress("ungwerukawonga@gmail.com", userEmail)); // Set the recipient email
            message.Subject = "Verification Code";

            // Generate the body of the email containing the random code
            string verificationCode = GenerateAndSaveCode(userEmail); // Implement this method
            message.Body = new TextPart("plain")
            {
                Text = $"Your verification code is: {verificationCode}"
            };

            // Send email using SMTP
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false); // SMTP server details
                client.Authenticate("kawongaemmanuel3@gmail.com", "ugzu wntl kzll niwb"); // SMTP authentication
                client.Send(message);
                client.Disconnect(true);
            }
        }
        //This method checks if the entered verification code matches the one saved in the database for the given email.
        public bool ValidateVerificationCode(string userEmail, string enteredCode)
        {
            // Retrieve the verification code from the database for the given email
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT Code FROM codes WHERE Email = @email", connection.GetMySqlConnection);
            command.Parameters.AddWithValue("@email", userEmail);

            connection.openConnect();
            object result = command.ExecuteScalar();
            connection.closeConnect();

            if (result != null)
            {
                // Compare the entered code with the retrieved code
                int savedCode = Convert.ToInt32(result);
                return savedCode == Convert.ToInt32(enteredCode);
            }
            else
            {
                // No verification code found for the given email
                return false;
            }
        }


    }
}
