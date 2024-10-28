/*
 * Author: Jaimy Mathon. René Kok, Lucas mathijsse
 * Date: 12-06-2024
 * Description: Add scores to a match 
*/

using T8_PraktijkProject.Model;
using T8_PraktijkProject.Controller;

namespace T8_PraktijkProject.View
{
    public partial class frmAddScore : Form
    {
        private int matchId;
        private WedstrijdController wedstrijdController;

        public frmAddScore()
        {
            InitializeComponent();
            wedstrijdController = new WedstrijdController();
        }

        // set match data function
        public void SetMatchData(WedstrijdModel match)
        {
            if (match == null)
            {
                MessageBox.Show("Match data is null");
                return;
            }

            matchId = match.WedstrijdId;

            PlayerModel deelnemer1 = match.Deelnemer1;
            PlayerModel deelnemer2 = match.Deelnemer2;

            // Check if both are filled
            if (deelnemer1 == null || deelnemer2 == null)
            {
                MessageBox.Show("One of the players is null");
                return;
            }

            lblDeelnemer1Id.Text = deelnemer1?.Achternaam;
            lblDeelnemer2Id.Text = deelnemer2?.Achternaam;

            pictureBoxSpeler1.Image = GetPlayerImageById(match.Deelnemer1.SpelerId);
            pictureBoxSpeler2.Image = GetPlayerImageById(match.Deelnemer2.SpelerId);

            LoadScores();
        }

        // Load the scores
        private void LoadScores()
        {
            if (matchId <= 0)
            {
                MessageBox.Show("Invalid matchId");
                return;
            }

            try
            {
                var (puntenDeelnemer1, puntenDeelnemer2) = wedstrijdController.GetScores(matchId);
                txtScorePlayer1.Text = puntenDeelnemer1.ToString();
                txtScorePlayer2.Text = puntenDeelnemer2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // get player image by id
        private Image GetPlayerImageById(int id)
        {
            PlayerModel player = wedstrijdController.GetPlayerById(id);
            // trying to get the image
            if (player != null && !string.IsNullOrEmpty(player.Afbeelding))
            {
                try
                {
                    return Image.FromFile(player.Afbeelding);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            return null;
        }

        // update the scores function
        private void UpdateScores()
        {
            if (matchId <= 0)
            {
                MessageBox.Show("Invalid matchId");
                return;
            }

            if (int.TryParse(txtScorePlayer1.Text, out int scoreDeelnemer1) &&
                int.TryParse(txtScorePlayer2.Text, out int scoreDeelnemer2))
            {

                // If it is tie
                if (scoreDeelnemer1 == scoreDeelnemer2)
                {
                    MessageBox.Show("Er kan geen gelijkspel plaatsvinden.", "Geen gelijkspel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    wedstrijdController.UpdateScores(matchId, scoreDeelnemer1, scoreDeelnemer2);
                    MessageBox.Show("Scores updated successfully!");
                }
                // Else there is a error
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating scores: {ex.Message}");
                }
            }
            // No input
            else
            {
                MessageBox.Show("Invalid score input");
            }
        }

        // Btn for updating
        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            UpdateScores();
        }
    }
}
