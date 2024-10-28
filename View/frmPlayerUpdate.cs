/*
 * Author: Lucas Mathijsse
 * Date: 10-06-2024
 * Description: Project Thema 8 Updating a player
*/

using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmPlayerUpdate : Form
    {
        private PlayerModel _player;
        // Save the image path
        private string imagePath;

        public frmPlayerUpdate(PlayerModel player)
        {
            InitializeComponent();

            _player = player;

            // Fill the textboxes with the existing data
            voornaam.Text = player.Voornaam;
            tussenvoegsel.Text = player.Tussenvoegsel;
            achternaam.Text = player.Achternaam;
            geboortedatum.Text = player.Geboortedatum.ToString("yyyy-MM-dd");
            disciplines.Text = player.Disciplines;
            wins.Text = player.Wins.ToString();
            losses.Text = player.Losses.ToString();
            imagePath = player.Afbeelding;
            playerImage.ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
        }

        private void frmPlayerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            // Check if all the fiels are filled 
            if (string.IsNullOrWhiteSpace(voornaam.Text) || string.IsNullOrWhiteSpace(achternaam.Text) ||
                string.IsNullOrWhiteSpace(geboortedatum.Text) || string.IsNullOrWhiteSpace(disciplines.Text) ||
                string.IsNullOrWhiteSpace(wins.Text) || string.IsNullOrWhiteSpace(losses.Text))
            {
                MessageBox.Show("Vul alle verplichte velden in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if there is a valid birth date
            if (!DateTime.TryParse(geboortedatum.Text, out DateTime parsedGeboortedatum))
            {
                MessageBox.Show("Ongeldige geboortedatum.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if the birth of date is not in the future
            if (parsedGeboortedatum > DateTime.Now)
            {
                MessageBox.Show("Geboortedatum kan niet in de toekomst liggen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the wins or loses are valid numbers
            if (!int.TryParse(wins.Text, out int parsedWins) || !int.TryParse(losses.Text, out int parsedLosses))
            {
                MessageBox.Show("Wins en losses moeten geldige gehele getallen zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if the image is not null
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Kies een afbeelding voor de speler.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the player object with the updated data
            _player.Voornaam = voornaam.Text;
            _player.Tussenvoegsel = tussenvoegsel.Text;
            _player.Achternaam = achternaam.Text;
            _player.Geboortedatum = parsedGeboortedatum;
            _player.Disciplines = disciplines.Text;
            _player.Wins = parsedWins;
            _player.Losses = parsedLosses;
            _player.Afbeelding = imagePath;

            // Call the update method on the PlayerController
            PlayerController playerController = new PlayerController();
            int rowsAffected = playerController.Update(_player);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Spelergegevens succesvol bijgewerkt.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Er is iets misgegaan bij het bijwerken van de spelergegevens.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previewBtn_Click_1(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    playerImage.ImageLocation = imageLocation;

                    // Move image to the folder
                    string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
                    if (!Directory.Exists(assetsPath))
                    {
                        Directory.CreateDirectory(assetsPath);
                    }

                    string targetPath = Path.Combine(assetsPath, Path.GetFileName(imageLocation));
                    File.Copy(imageLocation, targetPath, true);

                    // Save the path in a variable
                    imagePath = $"assets/{Path.GetFileName(imageLocation)}";
                }
            }
            // Else there is something wrong
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
