/*
 * Author: Jaimy Mathon
 * Date: 08-06-2024
 * Description: Project Thema 8 Speler View
*/

using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmSpelerView : Form
    {
        private PlayerController playerController;
        private singlePlayerFrame selectedItemFrame;

        public frmSpelerView()
        {
            InitializeComponent();
            playerController = new PlayerController();

            // Enable AutoScroll for the FlowLayoutPanel
            spelerFLP.AutoScroll = true;

            // Set the FlowDirection to LeftToRight
            spelerFLP.FlowDirection = FlowDirection.LeftToRight;

            LoadPlayer();
        }

        // Load player function
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

        // Player frame click function
        private void PlayerFrame_Click(object sender, EventArgs e)
        {
            if (sender is singlePlayerFrame)
            {
                // Deselect previous item
                if (selectedItemFrame != null)
                {
                    selectedItemFrame.BackColor = Color.FromArgb(20, 20, 20);
                }

                // Select new item
                selectedItemFrame = (singlePlayerFrame)sender;
                selectedItemFrame.BackColor = Color.LightBlue;
            }
        }

        // Delete btn function
        private void verwijderBtn_Click(object sender, EventArgs e)
        {
            deletePlayer();
        }
        // Delete function
        private void deletePlayer()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                if (selectedItemFrame != null)
                {
                    // Confirm selection
                    DialogResult result = MessageBox.Show("Weet je zeker dat je deze speler wilt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Get SpelerId from selectedItemFrame
                        if (int.TryParse(selectedItemFrame.Tag.ToString(), out int spelerId))
                        {
                            // Delete from database
                            playerController.Delete(spelerId);
                            spelerFLP.Controls.Remove(selectedItemFrame);
                            selectedItemFrame = null;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update btn function
        private void updateBtn_Click(object sender, EventArgs e)
        {
            updatePlayer();
        }

        // Update function
        private void updatePlayer()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                if (selectedItemFrame != null)
                {
                    // Get SpelerId from selectedItemFrame
                    if (int.TryParse(selectedItemFrame.Tag.ToString(), out int spelerId))
                    {
                        PlayerModel player = playerController.GetPlayerDataFromPlayerId(spelerId);

                        if (player != null)
                        {
                            frmPlayerUpdate playerUpdate = new frmPlayerUpdate(player);
                            playerUpdate.Show();
                        }
                        else
                        {
                            MessageBox.Show("Speler niet gevonden.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ongeldige SpelerID.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geen speler geselecteerd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // add btn function
        private void toevoegenBtn_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.IsLoggedIn)
            {


                frmPlayerAdd playerAdd = new frmPlayerAdd();
                playerAdd.Show();
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
