/*
 * Author: Jaimy Mathon
 * Date: 09-06-2024
 * Description: Project Thema 8 Wedstrijd View Specifieke Ronde
*/

using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class singlePlayerFrame : UserControl
    {
        public singlePlayerFrame()
        {
            InitializeComponent();
        }
        public void SetSpelerData(PlayerModel speler)
        {
            // Fill the labels with the player data
            nameLbl.Text = $"{speler.Voornaam} {speler.Tussenvoegsel} {speler.Achternaam}";
            SetAgeLabel(ageLbl, CalculateAge(speler.Geboortedatum).ToString());
            SetDisciplinesLabel(disciplinesLbl, speler.Disciplines);
            winLbl.Text = speler.Wins.ToString();
            lossLbl.Text = speler.Losses.ToString();

            if (!string.IsNullOrEmpty(speler.Afbeelding))
            {
                try
                {
                    // Fill the picture box with the image
                    SpelerPicture.Image = Image.FromFile(speler.Afbeelding);
                }
                // Else there is a error
                catch (Exception ex)
                {
                    MessageBox.Show($"Fout bij het laden van de afbeelding: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // Calculate the age with the birth of date
        private int CalculateAge(DateTime geboortedatum)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - geboortedatum.Year;
            if (geboortedatum.Date > today.AddYears(-age)) age--;
            return age;
        }

        // Specific method for showing the "" around the discipline 
        private void SetDisciplinesLabel(Label label, string value)
        {
            label.Text = $"\"{value}\"";
        }

        // Specific method for showing the age
        private void SetAgeLabel(Label label, string value)
        {
            label.Text = $"{value} years old";
        }
    }
}
