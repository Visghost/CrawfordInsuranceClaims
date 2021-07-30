using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrawfordInsuranceClaims
{
    public class LoginProcedure
    {
        private const int UsersUsername    = 0;
        private const int UsersDisplayName = 1;
        private const int UsersActive      = 2;
        private const int UsersId          = 3;

        // Normally I would make a data object. But for this a single variable will do
        public string DisplayName;
        public bool Successful { get; }

        private bool SuccessfulLogin(SqlDataReader reader)
        {
            reader.Read();
            Console.WriteLine($"Account found (Id:{reader.GetInt32(UsersId)})");
            if (reader.IsDBNull(UsersDisplayName)) {
                DisplayName = reader.GetString(UsersUsername);
            } else {
                DisplayName = reader.GetString(UsersDisplayName);
            }
            // Check if the account is disabled
            if (!reader.GetBoolean(UsersActive))
            {
                MessageBox.Show($"{DisplayName}, this account is currently disabled. Contact an admin to resolve this.");
                return false;
            }
            return true;
        }

        public LoginProcedure(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserName, DisplayName, Active, UserId FROM Users WHERE UserName = @Username AND Password = @Password"))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("Password", password);
                    connection.Open();

                    Console.WriteLine("Retrieving login data...");
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No account found");
                                MessageBox.Show("Your username or password is incorrect");
                            }
                            else
                            {
                                Successful = SuccessfulLogin(reader);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception occured while finding account details: " + e.Message);
                    }
                }
            }
        }
    }
}
