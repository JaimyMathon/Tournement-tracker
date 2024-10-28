/*
    Naam:   Lucas Matthijsse, René Kok, Jaimy Mathon
    Klas:   IO1S2AV
    Datum:  30-5-2024

    Omschrijving:   WedstrijdController
*/

using System.Data.SqlClient;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.Controller
{
    class WedstrijdController
    {
        // DEFAULT
        //private static string connectionString = @"Data Source=.\SQLEXPRESS; Database=T8_Project_UFC; Integrated Security=True;";
        // RENE LAPTOP
        // private static string connectionString = @"Data Source=MSI\SQLEXPRESS01;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // RENE PC
        // private static string connectionString = @"Data Source=DESKTOP-854M7FR;Initial Catalog=T8_Project_UFC;Integrated Security=True";
        // JAIMY LAPTOP
        public static string connectionString = @"Server=tcp:praktijopdracht.database.windows.net,1433;Initial Catalog=T8_Project_UFC;Persist Security Info=False;User ID=Jaimy;Password=UfcFightNight!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        // Read Function
        public List<WedstrijdModel> Read()
        {
            List<WedstrijdModel> wedstrijdList = new List<WedstrijdModel>();

            string query = @"
            SELECT *
            FROM vw_wedstrijdspeler
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();
                        // cmd.ExecuteNonQuery(); --> UPDATE, DELETE, CREATE
                        SqlDataReader reader = cmd.ExecuteReader(); 
                        while (reader.Read())
                        {
                            // Create a match
                            WedstrijdModel wedstrijd = new WedstrijdModel();
                            wedstrijd.WedstrijdId = (int)reader["WedstrijdId"];
                            wedstrijd.PouleId = (int)reader["PouleId"];
                            wedstrijd.Tijd = (DateTime)reader["Tijd"];
                            wedstrijd.Ring = (string)reader["Ring"];
                            wedstrijd.Ronde = (int)reader["Ronde"];
                            wedstrijd.WedstrijdNummer = (int)reader["WedstrijdNummer"];

                            // Creating player 1
                            PlayerModel player1 = new PlayerModel {
                                SpelerId = (int)reader["P1_spelerid"],
                                Voornaam = (string)reader["P1_voornaam"],
                                Tussenvoegsel = reader["P1_tussenvoegsel"] as string,
                                Achternaam = (string)reader["P1_achternaam"],
                                Geboortedatum = (DateTime)reader["P1_geboortedatum"],
                                Disciplines = (string)reader["P1_disciplines"],
                                Wins = (int)reader["P1_wins"],
                                Losses = (int)reader["P1_losses"],
                                Afbeelding = (string)reader["P1_afbeelding"],
                            };

                            // Player information in match
                            wedstrijd.Deelnemer1 = player1;
                            wedstrijd.PuntenDeelnemer1 = (int)reader["PuntenDeelnemer1"];

                            // Creating player2
                            PlayerModel player2 = new PlayerModel
                            {
                                SpelerId = (int)reader["P2_spelerid"],
                                Voornaam = (string)reader["P2_voornaam"],
                                Tussenvoegsel = reader["P2_tussenvoegsel"] as string,
                                Achternaam = (string)reader["P2_achternaam"],
                                Geboortedatum = (DateTime)reader["P2_geboortedatum"],
                                Disciplines = (string)reader["P2_disciplines"],
                                Wins = (int)reader["P2_wins"],
                                Losses = (int)reader["P2_losses"],
                                Afbeelding = (string)reader["P2_afbeelding"],
                            };

                            // Player information in match
                            wedstrijd.Deelnemer2 = player2;
                            wedstrijd.PuntenDeelnemer2 = (int)reader["PuntenDeelnemer2"];


                            // Add players to to the match
                            wedstrijdList.Add(wedstrijd);

                        }
                    }
                    // Else there is something wrong
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het laden van de modules: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            return wedstrijdList;
        }

        // Read round function
        public List<WedstrijdModel> ReadRound(int roundNumber)
        {
            List<WedstrijdModel> wedstrijdList = new List<WedstrijdModel>();

            string query = @$"
            SELECT *
            FROM vw_wedstrijdspeler
            WHERE Ronde = '{roundNumber}'
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();
                        // cmd.ExecuteNonQuery(); --> UPDATE, DELETE , CREATE
                        SqlDataReader reader = cmd.ExecuteReader(); 
                        while (reader.Read())
                        {
                            // Create a match
                            WedstrijdModel wedstrijd = new WedstrijdModel();
                            wedstrijd.WedstrijdId = (int)reader["WedstrijdId"];
                            wedstrijd.PouleId = (int)reader["PouleId"];
                            wedstrijd.Tijd = (DateTime)reader["Tijd"];
                            wedstrijd.Ring = (string)reader["Ring"];
                            wedstrijd.Ronde = (int)reader["Ronde"];
                            wedstrijd.WedstrijdNummer = (int)reader["WedstrijdNummer"];

                            // Creating player 1
                            PlayerModel player1 = new PlayerModel
                            {
                                SpelerId = (int)reader["P1_spelerid"],
                                Voornaam = (string)reader["P1_voornaam"],
                                Tussenvoegsel = reader["P1_tussenvoegsel"] as string,
                                Achternaam = (string)reader["P1_achternaam"],
                                Geboortedatum = (DateTime)reader["P1_geboortedatum"],
                                Disciplines = (string)reader["P1_disciplines"],
                                Wins = (int)reader["P1_wins"],
                                Losses = (int)reader["P1_losses"],
                                Afbeelding = (string)reader["P1_afbeelding"],
                            };

                            // Player information in match
                            wedstrijd.Deelnemer1 = player1;
                            wedstrijd.PuntenDeelnemer1 = (int)reader["PuntenDeelnemer1"];

                            // Creating player 2
                            PlayerModel player2 = new PlayerModel
                            {
                                SpelerId = (int)reader["P2_spelerid"],
                                Voornaam = (string)reader["P2_voornaam"],
                                Tussenvoegsel = reader["P2_tussenvoegsel"] as string,
                                Achternaam = (string)reader["P2_achternaam"],
                                Geboortedatum = (DateTime)reader["P2_geboortedatum"],
                                Disciplines = (string)reader["P2_disciplines"],
                                Wins = (int)reader["P2_wins"],
                                Losses = (int)reader["P2_losses"],
                                Afbeelding = (string)reader["P2_afbeelding"],
                            };

                            // Player information in match
                            wedstrijd.Deelnemer2 = player2;
                            wedstrijd.PuntenDeelnemer2 = (int)reader["PuntenDeelnemer2"];


                            // Add player to the match
                            wedstrijdList.Add(wedstrijd);

                        }
                    }
                    // else there is something wrong
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het laden van de modules: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            return wedstrijdList;
        }
        // Add function
        public int Add(WedstrijdModel wedstrijd)
        {
            string query = @"
            INSERT INTO Wedstrijd (WedstrijdNummer, PouleId, Tijd, Ring, Ronde, Deelnemer1Id, PuntenDeelnemer1, Deelnemer2Id, PuntenDeelnemer2)
            OUTPUT INSERTED.WedstrijdId
            VALUES (@WedstrijdNummer, @PouleId, @Tijd, @Ring, @Ronde, @Deelnemer1Id, @PuntenDeelnemer1, @Deelnemer2Id, @PuntenDeelnemer2)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Filling the parameters with real data
                    cmd.Parameters.AddWithValue("@WedstrijdNummer", wedstrijd.WedstrijdNummer);
                    cmd.Parameters.AddWithValue("@PouleId", wedstrijd.PouleId);
                    cmd.Parameters.AddWithValue("@Tijd", wedstrijd.Tijd);
                    cmd.Parameters.AddWithValue("@Ring", wedstrijd.Ring);
                    cmd.Parameters.AddWithValue("@Ronde", wedstrijd.Ronde);
                    cmd.Parameters.AddWithValue("@Deelnemer1Id", wedstrijd.Deelnemer1.SpelerId);
                    cmd.Parameters.AddWithValue("@PuntenDeelnemer1", wedstrijd.PuntenDeelnemer1);
                    cmd.Parameters.AddWithValue("@Deelnemer2Id", wedstrijd.Deelnemer2.SpelerId);
                    cmd.Parameters.AddWithValue("@PuntenDeelnemer2", wedstrijd.PuntenDeelnemer2);

                    try
                    {
                        conn.Open();
                        // Use ExecuteScalar to recieve the INSERTED.wedstrijdId
                        int insertedId = (int)cmd.ExecuteScalar();
                        return insertedId;
                    }
                    catch (Exception ex)
                    {
                        // Else there is something wrong
                        MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de wedstrijd: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1; 
                    }
                }
            }
        }

        // Delete function
        public void Delete(WedstrijdModel wedstrijd)
        {
            string query = $"DELETE FROM [Wedstrijd] WHERE WedstrijdNummer = @WedstrijdNummer AND Deelnemer1Id = @Deelnemer1Id AND Deelnemer2Id = Deelnemer2Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Filling the parameters with real data
                    cmd.Parameters.AddWithValue("@WedstrijdNummer", wedstrijd.WedstrijdNummer);
                    cmd.Parameters.AddWithValue("@Deelnemer1Id", wedstrijd.Deelnemer1.SpelerId);
                    cmd.Parameters.AddWithValue("@Deelnemer2Id", wedstrijd.Deelnemer2.SpelerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete everything
        public void DeleteAll()
        {
            string query = $"DELETE FROM [Wedstrijd] WHERE WedstrijdId > 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get scores Function
        public (int, int) GetScores(int matchId)
        {
            string query = "SELECT PuntenDeelnemer1, PuntenDeelnemer2 FROM Wedstrijd WHERE WedstrijdId = @WedstrijdId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Filling the paramters with real data
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@WedstrijdId", matchId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Get the match scores from the players
                    if (reader.Read())
                    {
                        int puntenDeelnemer1 = (int)reader["PuntenDeelnemer1"];
                        int puntenDeelnemer2 = (int)reader["PuntenDeelnemer2"];
                        return (puntenDeelnemer1, puntenDeelnemer2);
                    }
                    // Else there is a error
                    else
                    {
                        throw new Exception("No scores found for this match");
                    }
                }
            }
        }

        // Update scores function
        public void UpdateScores(int matchId, int scoreDeelnemer1, int scoreDeelnemer2)
        {
            string query = "UPDATE Wedstrijd SET PuntenDeelnemer1 = @ScoreDeelnemer1, PuntenDeelnemer2 = @ScoreDeelnemer2 WHERE WedstrijdId = @WedstrijdId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Filling the parameters with real data
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ScoreDeelnemer1", scoreDeelnemer1);
                command.Parameters.AddWithValue("@ScoreDeelnemer2", scoreDeelnemer2);
                command.Parameters.AddWithValue("@WedstrijdId", matchId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get player by id function
        public PlayerModel GetPlayerById(int id)
        {
            string query = "SELECT * FROM Players WHERE SpelerId = @SpelerId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Filling the parameters with real data
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SpelerId", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Get everything from player
                        return new PlayerModel
                        {
                            SpelerId = (int)reader["SpelerId"],
                            Voornaam = reader["Voornaam"].ToString(),
                            Tussenvoegsel = reader["Tussenvoegsel"].ToString(),
                            Achternaam = reader["Achternaam"].ToString(),
                            Geboortedatum = (DateTime)reader["Geboortedatum"],
                            Disciplines = reader["Disciplines"].ToString(),
                            Wins = (int)reader["Wins"],
                            Losses = (int)reader["Losses"],
                            Afbeelding = reader["Afbeelding"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}