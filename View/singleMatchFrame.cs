/*
 * Author: Jaimy Mathon
 * Date: 9-06-2024
 * Description: Project Thema 8 Single match information
*/

using T8_PraktijkProject.Model;
using T8_PraktijkProject.Controller;

namespace T8_PraktijkProject.View
{
    public partial class singleMatchFrame : UserControl
    {
        private WedstrijdModel wedstrijd;
        private WedstrijdController wedstrijdController;

        public singleMatchFrame()
        {
            InitializeComponent();
            wedstrijdController = new WedstrijdController();
        }

        // get all the match data
        public void SetMatchData(WedstrijdModel match)
        {
            wedstrijd = match;
            lblTijd.Text = wedstrijd.Tijd.ToString();
            lblRing.Text = match.Ring;
            lblRonde.Text = match.Ronde.ToString();

            PlayerModel deelnemer1 = match.Deelnemer1;
            PlayerModel deelnemer2 = match.Deelnemer2;

            lblDeelnemer1Id.Text = deelnemer1?.Achternaam;
            lblDeelnemer2Id.Text = deelnemer2?.Achternaam;

            pictureBoxSpeler1.Image = GetPlayerImageById(match.Deelnemer1.SpelerId);
            pictureBoxSpeler2.Image = GetPlayerImageById(match.Deelnemer2.SpelerId);
        }

        // get the player image
        private Image GetPlayerImageById(int id)
        {
            // recieve the player id 
            PlayerModel player = wedstrijdController.GetPlayerById(id);
            if (player != null && !string.IsNullOrEmpty(player.Afbeelding))
            {
                try
                {
                    // Look for the image with the player
                    return Image.FromFile(player.Afbeelding);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            return null;
        }

        // Button for showing the scores
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddScore addScore = new frmAddScore();
            addScore.SetMatchData(wedstrijd);
            addScore.Show();
        }
    }
}
