/*
 * Author: Lucas Mathijsse
 * Date: 7-06-2024
 * Description: Project Thema 8 Adding a player 
*/

using System.Data.SqlClient;
using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmPlayerAdd : Form
    {
        // save the image path
        private string imagePath; 

        public frmPlayerAdd()
        {
            InitializeComponent();
        }

        // function for adding the player
        private void toevoegenBtn_Click(object sender, EventArgs e)
        {
            // check if everything is filled 
            if (string.IsNullOrWhiteSpace(voornaam.Text) || string.IsNullOrWhiteSpace(achternaam.Text) ||
                string.IsNullOrWhiteSpace(geboortedatum.Text) || string.IsNullOrWhiteSpace(disciplines.Text) ||
                string.IsNullOrWhiteSpace(wins.Text) || string.IsNullOrWhiteSpace(losses.Text))
            {
                // error if not
                MessageBox.Show("Vul alle verplichte velden in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if there is a valid birth of date
            if (!DateTime.TryParse(geboortedatum.Text, out DateTime parsedGeboortedatum))
            {
                MessageBox.Show("Ongeldige geboortedatum.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the date of birth is not in the future
            if (parsedGeboortedatum > DateTime.Now)
            {
                MessageBox.Show("Geboortedatum kan niet in de toekomst liggen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the wins and loses are valid round numbers
            if (!int.TryParse(wins.Text, out int parsedWins) || !int.TryParse(losses.Text, out int parsedLosses))
            {
                MessageBox.Show("Wins en losses moeten geldige gehele getallen zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if there is a image
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Kies een afbeelding voor de speler.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new player
            var newPlayer = new PlayerModel
            {
                Voornaam = voornaam.Text,
                Tussenvoegsel = string.IsNullOrWhiteSpace(tussenvoegsel.Text) ? null : tussenvoegsel.Text,
                Achternaam = achternaam.Text,
                Geboortedatum = parsedGeboortedatum,
                Disciplines = disciplines.Text,
                Wins = parsedWins,
                Losses = parsedLosses,
                Afbeelding = imagePath
            };

            // add the player with the controller
            PlayerController playerController = new PlayerController();

            int rowsAffected = playerController.Add(newPlayer);

            // if success 
            if (rowsAffected > 0)
            {
                MessageBox.Show("Speler succesvol toegevoegd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // if error
            else
            {
                MessageBox.Show("Er is iets misgegaan bij het toevoegen van de speler.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Image button 
        private void previewBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                // Open the folder dialog
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    playerImage.ImageLocation = imageLocation;

                    // change the image directory to the assets folder
                    string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
                    if (!Directory.Exists(assetsPath))
                    {
                        Directory.CreateDirectory(assetsPath);
                    }

                    string targetPath = Path.Combine(assetsPath, Path.GetFileName(imageLocation));
                    File.Copy(imageLocation, targetPath, true);

                    // save the path with a variable
                    imagePath = $"assets/{Path.GetFileName(imageLocation)}";
                }
            }
            // if there is a error
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
