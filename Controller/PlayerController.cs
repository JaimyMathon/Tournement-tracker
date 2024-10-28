/*
    Naam:   Lucas Matthijsse, René Kok, Jaimy Mathon
    Klas:   IO1S2AV
    Datum:  30-5-2024

    Omschrijving:   PlayerController
 */

using T8_PraktijkProject.Model;
using System.Data.SqlClient;
using System.Numerics;


namespace T8_PraktijkProject.Controller
{
    public class PlayerController
    {
        // DEFAULT
        //private static string connectionString = @"Data Source=.\SQLEXPRESS; Database=T8_Project_UFC; Integrated Security=True;";
        // RENE LAPTOP
        // private static string connectionString = @"Data Source=MSI\SQLEXPRESS01;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // RENE PC
        // private static string connectionString = @"Data Source=DESKTOP-854M7FR;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // JAIMY LAPTOP
        public static string connectionString = @"Server=tcp:praktijopdracht.database.windows.net,1433;Initial Catalog=T8_Project_UFC;Persist Security Info=False;User ID=Jaimy;Password=UfcFightNight!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Read function 
        public List<PlayerModel> Read()
        {
            List<PlayerModel> playerList = new List<PlayerModel>();

            string query = @"
            SELECT * FROM Players";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {       
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            PlayerModel player = new PlayerModel();
                            player.SpelerId = (int)reader["SpelerId"];
                            player.Voornaam = reader["Voornaam"] != DBNull.Value ? (string)reader["Voornaam"] : null;
                            player.Tussenvoegsel = reader["Tussenvoegsel"] != DBNull.Value ? (string)reader["Tussenvoegsel"] : null;
                            player.Achternaam = reader["Achternaam"] != DBNull.Value ? (string)reader["Achternaam"] : null;
                            player.Geboortedatum = reader["Geboortedatum"] != DBNull.Value ? (DateTime)reader["Geboortedatum"] : DateTime.MinValue;
                            player.Disciplines = reader["Disciplines"] != DBNull.Value ? (string)reader["Disciplines"] : null;
                            player.Wins = reader["Wins"] != DBNull.Value ? (int)reader["Wins"] : 0;
                            player.Losses = reader["Losses"] != DBNull.Value ? (int)reader["Losses"] : 0;
                            player.Afbeelding = reader["Afbeelding"] != DBNull.Value ? (string)reader["Afbeelding"] : null;

                            // Add player to the list
                            playerList.Add(player);
                        }
                    }
                    // Else there is something wrong
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het laden van de modules: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return playerList;
        }

        // Add function 
        public int Add(PlayerModel player)
        {
            string connectionString = @"Server=tcp:praktijopdracht.database.windows.net,1433;Initial Catalog=Ufc_Fight_Night;Persist Security Info=False;User ID=Jaimy;Password=UfcFightNight!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO Players (Voornaam, Tussenvoegsel, Achternaam, Geboortedatum, Disciplines, Wins, Losses, Afbeelding) " +
                           "VALUES (@Voornaam, @Tussenvoegsel, @Achternaam, @Geboortedatum, @Disciplines, @Wins, @Losses, @Afbeelding)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Filling the parameters with real data
                    cmd.Parameters.AddWithValue("@Voornaam", player.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", (object)player.Tussenvoegsel ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Achternaam", player.Achternaam);
                    cmd.Parameters.AddWithValue("@Geboortedatum", player.Geboortedatum);
                    cmd.Parameters.AddWithValue("@Disciplines", player.Disciplines);
                    cmd.Parameters.AddWithValue("@Wins", player.Wins);
                    cmd.Parameters.AddWithValue("@Losses", player.Losses);
                    cmd.Parameters.AddWithValue("@Afbeelding", player.Afbeelding);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete Function
        public void Delete(int spelerId)
        {
            string query = @"DELETE FROM Wedstrijd WHERE Deelnemer1Id = @SpelerId OR Deelnemer2Id = @SpelerId;
                             DELETE FROM PoulePlayers WHERE SpelerId = @SpelerId;
                             DELETE FROM Players WHERE SpelerId = @SpelerId;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Filling the query with real data
                    cmd.Parameters.AddWithValue("@SpelerId", spelerId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    // Else there is something wrong
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de speler: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Get playerData by ID
        public PlayerModel GetPlayerDataFromPlayerId(int SpelerId)
        {
            PlayerModel player = null;

            string query = @"
            SELECT * FROM Players WHERE SpelerId = @SpelerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Filling the parameter with real data
                    cmd.Parameters.AddWithValue("@SpelerId", SpelerId);

                    try
                    {
                        conn.Open();
                        // Read function
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Using the playerModel
                            player = new PlayerModel
                            {
                                SpelerId = (int)reader["SpelerId"],
                                Voornaam = (string)reader["Voornaam"],
                                Tussenvoegsel = reader["Tussenvoegsel"] as string,
                                Achternaam = (string)reader["Achternaam"],
                                Geboortedatum = (DateTime)reader["Geboortedatum"],
                                Disciplines = (string)reader["Disciplines"],
                                Wins = (int)reader["Wins"],
                                Losses = (int)reader["Losses"],
                                Afbeelding = (string)reader["Afbeelding"]
                            };
                        }
                    }
                    // Else there is something wrong
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het laden van de speler: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return player;
        }

        // UPDATE Function
        public int Update(PlayerModel player)
        {
            // Query for updating the player data in the database
            string cQuery = @"
                UPDATE Players
                SET 
                    Voornaam = @Voornaam, 
                    Tussenvoegsel = @Tussenvoegsel, 
                    Achternaam = @Achternaam, 
                    Geboortedatum = @Geboortedatum,
                    Disciplines = @Disciplines,
                    Wins = @Wins,
                    Losses = @Losses,
                    Afbeelding = @Afbeelding
                WHERE 
                    SpelerID = @SpelerID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Executing the query
                using (SqlCommand cmd = new SqlCommand(cQuery, conn))
                {
                    conn.Open();

                    // Filling the parameters with real data
                    cmd.Parameters.AddWithValue("@Voornaam", player.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", (object)player.Tussenvoegsel ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Achternaam", player.Achternaam);
                    cmd.Parameters.AddWithValue("@Geboortedatum", player.Geboortedatum);
                    cmd.Parameters.AddWithValue("@Disciplines", player.Disciplines);
                    cmd.Parameters.AddWithValue("@Wins", player.Wins);
                    cmd.Parameters.AddWithValue("@Losses", player.Losses);
                    cmd.Parameters.AddWithValue("@Afbeelding", (object)player.Afbeelding ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SpelerID", player.SpelerId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

