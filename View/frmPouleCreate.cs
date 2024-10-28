/*
 * Author: Rene Kok
 * Date: 19-06-2024
 * Description: Project Thema 8 Poule Create Window
*/

using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmPouleCreate : Form
    {
        private PlayerController playerController;
        private singlePlayerFrame selectedItemFrame;
        private List<PlayerModel> newPlayerList = new List<PlayerModel>();
        private int playerCount;
        private int huidigeRonde;

        public frmPouleCreate(int huidigeRonde)
        {
            InitializeComponent();
            playerController = new PlayerController();

            // Enable AutoScroll for the FlowLayoutPanel
            spelerFLP.AutoScroll = true;

            // Set the FlowDirection to LeftToRight
            spelerFLP.FlowDirection = FlowDirection.LeftToRight;

            LoadPlayer();
            this.huidigeRonde = huidigeRonde;
        }

        private void LoadPlayer()
        {
            List<PlayerModel> spelers = playerController.Read();

            foreach (PlayerModel speler in spelers)
            {
                singlePlayerFrame playerFrame = new singlePlayerFrame();
                playerFrame.SetSpelerData(speler);

                // Set the Tag property to the SpelerId
                playerFrame.Tag = speler.SpelerId;

                playerFrame.Click += PlayerFrame_Click;
                spelerFLP.Controls.Add(playerFrame);
            }
        }

        private void PlayerFrame_Click(object sender, EventArgs e)
        {
            if (sender is singlePlayerFrame)
            {
                PlayerModel player = new PlayerModel();

                // Deselect previous item
                if (selectedItemFrame != null && !newPlayerList.Contains(player))
                {
                    selectedItemFrame.BackColor = Color.FromArgb(20, 20, 20);
                }

                // Select new item
                selectedItemFrame = (singlePlayerFrame)sender;

                // Get SpelerId from selectedItemFrame
                if (int.TryParse(selectedItemFrame.Tag.ToString(), out int spelerId))
                {
                    player = playerController.GetPlayerDataFromPlayerId(spelerId);

                    if (player != null)
                    {
                        // Deselect previous item
                        if (newPlayerList.Contains(player))
                        {
                            selectedItemFrame.BackColor = Color.Green;
                        }
                        else
                        {
                            if (playerCount < 32)
                            {
                                selectedItemFrame.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                MessageBox.Show("Maximaal aantal spelers geselecteerd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        lblPlayerCount.Text = $"{playerCount} / 32";
                    }
                }
            }
        }

        private void btnSelecteer_Click(object sender, EventArgs e)
        {
            SelectPlayer();
        }

        private void SelectPlayer()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                if (selectedItemFrame != null)
                {
                    // Get SpelerId from selectedItemFrame
                    if (int.TryParse(selectedItemFrame.Tag.ToString(), out int spelerId))
                    {
                        PlayerModel newPlayer = playerController.GetPlayerDataFromPlayerId(spelerId);

                        if (newPlayer != null)
                        {
                            if (!newPlayerList.Contains(newPlayer) && playerCount < 32)
                            {
                                newPlayerList.Add(newPlayer);
                                selectedItemFrame.BackColor = Color.Green;
                                playerCount++;
                            }
                            else if (newPlayerList.Contains(newPlayer))
                            {
                                newPlayerList.Remove(newPlayer);
                                selectedItemFrame.BackColor = Color.FromArgb(20, 20, 20);
                                playerCount--;
                            }

                            lblPlayerCount.Text = $"{playerCount} / 32";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            DialogResult result = MessageBox.Show("Weet je zeker dat wilt stoppen met het maken van een poule?", "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCreatePoule_Click(object sender, EventArgs e)
        {
            CreatePoule();
        }

        private void CreatePoule()
        {
            if (UserSession.Instance.IsLoggedIn)
            {

                if (playerCount != 32)
                {
                    MessageBox.Show("Er moeten precies 32 spelers geselecteerd zijn om een poule aan te maken.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Creëer nieuwe wedstrijden voor de volgende ronde
                WedstrijdController controller = new WedstrijdController();
                List<WedstrijdModel> nieuweWedstrijden = new List<WedstrijdModel>();
                int wedstrijdNummer = 1;

                // Loopen door de playerlist om een wedstrijd te maken per 2 spelers
                for (int i = 0; i < newPlayerList.Count; i += 2)
                {
                    // Zolang je tweeparen kan maken
                    if (i + 1 < newPlayerList.Count)
                    {
                        // Deelnemers selecteren
                        PlayerModel deelnemer1 = newPlayerList[i];
                        PlayerModel deelnemer2 = newPlayerList[i + 1];

                        // Nieuwe wedstrijd aanmaken
                        WedstrijdModel nieuweWedstrijd = new WedstrijdModel
                        {
                            WedstrijdNummer = wedstrijdNummer,
                            PouleId = 1,
                            Ring = "Ring A",
                            Ronde = huidigeRonde, // Volgende ronde
                            Tijd = DateTime.Now,
                            Deelnemer1 = deelnemer1,
                            PuntenDeelnemer1 = 0,
                            Deelnemer2 = deelnemer2,
                            PuntenDeelnemer2 = 0
                        };
                        // Aan een lijst toevoegen
                        nieuweWedstrijden.Add(nieuweWedstrijd);

                        // Nummer verhogen zodat positionering klopt
                        wedstrijdNummer++;
                    }
                }

                // Voeg de wedstrijden toe aan de database en lijst
                foreach (WedstrijdModel wedstrijd in nieuweWedstrijden)
                {
                    // Voeg de nieuwe wedstrijd toe aan de database en krijg het gegenereerde WedstrijdId
                    int wedstrijdId = controller.Add(wedstrijd);
                    if (wedstrijdId != -1) // Controleer of het toevoegen succesvol was
                    {
                        wedstrijd.WedstrijdId = wedstrijdId;
                        frmPoulesWindow.nieuwsteWedstrijden.Add(wedstrijd);
                    }
                }

                // Melden en wegwezen
                MessageBox.Show("Eerste ronde is aangemaakt");
                this.Close();
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
