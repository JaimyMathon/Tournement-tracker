/*
 * Author: Jaimy Mathon
 * Date: 16-06-2024
 * Description: Project Thema 8 Login controller for logging in to the admin account
*/

using System.Data.SqlClient;


namespace T8_PraktijkProject.Controller
{
    public class LoginController
    {
        // DEFAULT
        private static string connectionString = @"Data Source=MSI\SQLEXPRESS; Database=T8_Project_UFC; Integrated Security=True;";
        // RENE LAPTOP
        // private static string connectionString = @"Data Source=MSI\SQLEXPRESS01;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // RENE PC
        // private static string connectionString = @"Data Source=DESKTOP-854M7FR;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // JAIMY LAPTOP
        //public static string connectionString = @"Server=tcp:praktijopdracht.database.windows.net,1433;Initial Catalog=T8_Project_UFC;Persist Security Info=False;User ID=Jaimy;Password=UfcFightNight!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Check the username and passeord if they match
        public bool AuthenticateUser(string gebruikersnaam, string wachtwoord)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM beheerders WHERE gebruikersnaam = @gebruikersnaam AND wachtwoord = @wachtwoord";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Fill the parameters with the real data
                    command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                    command.Parameters.AddWithValue("@wachtwoord", wachtwoord);

                    // Check if there is a user
                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }
    }
}
