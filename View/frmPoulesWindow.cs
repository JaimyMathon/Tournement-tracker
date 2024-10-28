/*
 * Author: Rene Kok
 * Date: 04-06-2024
 * Description: Poule/Wedstrijd overzicht
*/

using System;
using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmPoulesWindow : Form
    {
        public int huidigeRonde;
        public static List<WedstrijdModel> nieuwsteWedstrijden = new List<WedstrijdModel>();

        public frmPoulesWindow()
        {
            InitializeComponent();
        }

        private void frmPoulesWindowcs_Load(object sender, EventArgs e)
        {

            RefreshWindow();

        }

        private void RefreshWindow()
        {
            // Initialiseer variabelen
            huidigeRonde = 1;

            // Initialiseer controller
            WedstrijdController controller = new WedstrijdController();
            List<WedstrijdModel> wedstrijden = controller.Read();

            // Counters voor de volgende rondes
            //int legCounter = 1;
            int nextRoundCounter = 1;
            int deelnemersPerRonde = 32; // Aantal wedstrijden per ronde (32 spelers, dus 16 wedstrijden in eerste ronde)

            foreach (WedstrijdModel wedstrijd in wedstrijden)
            {
                string btnDeelnemer1Name;
                string btnDeelnemer2Name;
                // Initialiseer variabelen
                //if (huidigeRonde == 1)
                //{
                //    btnDeelnemer1Name = $"btnGame{legCounter}{wedstrijd.WedstrijdNummer * 2}";
                //    btnDeelnemer2Name = $"btnGame{legCounter}{wedstrijd.WedstrijdNummer * 2 - 1}";
                //}
                //else
                //{
                //    btnDeelnemer1Name = $"btnGame{legCounter}{nextRoundCounter}";
                //    btnDeelnemer2Name = $"btnGame{legCounter}{nextRoundCounter + 1}";
                //}
                int knopnr = wedstrijd.WedstrijdNummer * 2 - 1;
                btnDeelnemer1Name = $"btnGame{wedstrijd.Ronde}{knopnr}";
                knopnr++;
                btnDeelnemer2Name = $"btnGame{wedstrijd.Ronde}{knopnr}";


                // Initialiseer controller
                PlayerController playerController = new PlayerController();
                PlayerModel player1 = wedstrijd.Deelnemer1;
                PlayerModel player2 = wedstrijd.Deelnemer2;

                // Vind de knoppen op basis van hun naam
                Button btnDeelnemer1 = this.Controls.Find(btnDeelnemer1Name, true).FirstOrDefault() as Button;
                Button btnDeelnemer2 = this.Controls.Find(btnDeelnemer2Name, true).FirstOrDefault() as Button;

                // Vul de knoppen met de juiste tekst
                if (btnDeelnemer1 != null)
                {
                    btnDeelnemer1.Text = $"D1: {player1.Achternaam}";
                }

                if (btnDeelnemer2 != null)
                {
                    btnDeelnemer2.Text = $"D2: {player2.Achternaam}";
                }

                // Ga 2 velden verder in de poule lijst (volgende wedstrijd)
                nextRoundCounter += 2;

                // Verhoog de legCounter en reset nextRoundCounter indien nodig
                if (nextRoundCounter > deelnemersPerRonde)
                {
                    nextRoundCounter = 1;
                    //legCounter++;

                    // Controleer of alle rondes zijn voltooid
                    if (huidigeRonde <= 5) // Het aantal rondes kan hier hard gecodeerd zijn, pas dit aan indien nodig
                    {
                        // Halveer het aantal wedstrijden voor de volgende ronde
                        deelnemersPerRonde /= 2;
                        huidigeRonde++;
                    }
                    else
                    {
                        // Stop de lus als alle rondes zijn voltooid
                        break;

                    }
                }
            }
        }

        // Genereer volgende ronde
        private void btnNextRound_Click(object sender, EventArgs e)
        {
            nextRound();
        }

        private void nextRound()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                WedstrijdController controller = new WedstrijdController();
                List<WedstrijdModel> wedstrijden = controller.ReadRound(huidigeRonde - 1);
                List<PlayerModel> winnaars = new List<PlayerModel>();
                nieuwsteWedstrijden.Clear();

                // Haal de winnaars van de huidige ronde op
                foreach (WedstrijdModel wedstrijd in wedstrijden)
                {
                    PlayerModel winnaar;
                    if (wedstrijd.PuntenDeelnemer1 == 0 || wedstrijd.PuntenDeelnemer2 == 0)
                    {
                        MessageBox.Show($"Wedstrijd {wedstrijd.Deelnemer1.Achternaam} vs {wedstrijd.Deelnemer2.Achternaam} heeft nog 0 punten");
                        break;
                    }
                    else if (wedstrijd.PuntenDeelnemer1 > wedstrijd.PuntenDeelnemer2)
                    {
                        winnaar = wedstrijd.Deelnemer1;
                    }
                    else
                    {
                        winnaar = wedstrijd.Deelnemer2;
                    }
                    winnaars.Add(winnaar);

                    //MessageBox.Show(winnaar.SpelerId.ToString());
                }

                // Creëer nieuwe wedstrijden voor de volgende ronde
                List<WedstrijdModel> nieuweWedstrijden = new List<WedstrijdModel>();
                int wedstrijdNummer = 1;
                for (int i = 0; i < winnaars.Count; i += 2)
                {
                    if (i + 1 < winnaars.Count)
                    {
                        PlayerModel deelnemer1 = winnaars[i];
                        PlayerModel deelnemer2 = winnaars[i + 1];

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
                        nieuweWedstrijden.Add(nieuweWedstrijd);

                        wedstrijdNummer++;
                    }

                    if (huidigeRonde == 6)
                    {
                        PlayerModel winnaar = winnaars[i];

                        btnGame61.Text = $"Winnaar: {winnaar.Achternaam}";
                    }
                }

                // Sla de nieuwe wedstrijden op
                foreach (WedstrijdModel wedstrijd in nieuweWedstrijden)
                {
                    // Voeg de nieuwe wedstrijd toe aan de database en krijg het gegenereerde WedstrijdId
                    int wedstrijdId = controller.Add(wedstrijd);
                    if (wedstrijdId != -1) // Controleer of het toevoegen succesvol was
                    {
                        wedstrijd.WedstrijdId = wedstrijdId;
                        nieuwsteWedstrijden.Add(wedstrijd);
                    }
                }

                // Verhoog de huidige ronde
                huidigeRonde++;
                RefreshWindow();
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndoNextRound_Click(object sender, EventArgs e)
        {
            UndoNextRound();
        }

        private void UndoNextRound()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                if (nieuwsteWedstrijden.Count > 0)
                {
                    // Initialiseer variabelen
                    WedstrijdController controller = new WedstrijdController();
                    string btnDeelnemer1Name;
                    string btnDeelnemer2Name;

                    foreach (WedstrijdModel wedstrijd in new List<WedstrijdModel>(nieuwsteWedstrijden))
                    {
                        // Verwijder de wedstrijd uit de database en uit de nieuwsteWedstrijden zodat je maar 1 keer kunt weghalen
                        controller.Delete(wedstrijd);
                        nieuwsteWedstrijden.Remove(wedstrijd);

                        int knopnr = wedstrijd.WedstrijdNummer * 2 - 1;
                        btnDeelnemer1Name = $"btnGame{wedstrijd.Ronde}{knopnr}";
                        knopnr++;
                        btnDeelnemer2Name = $"btnGame{wedstrijd.Ronde}{knopnr}";

                        // Vind de knoppen op basis van hun naam
                        Button btnDeelnemer1 = this.Controls.Find(btnDeelnemer1Name, true).FirstOrDefault() as Button;
                        Button btnDeelnemer2 = this.Controls.Find(btnDeelnemer2Name, true).FirstOrDefault() as Button;

                        btnDeelnemer1.Text = "";
                        btnDeelnemer2.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show($"Er zijn geen wedstrijden die je ongedaan kan maken");
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open een scherm om de wedstrijden te beoordelen
        private void btnRateGames_Click(object sender, EventArgs e)
        {
            RateGames();
        }

        private void RateGames()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                if (nieuwsteWedstrijden.Count > 0)
                {
                    frmWedstrijdRondeView rondeView = new frmWedstrijdRondeView(nieuwsteWedstrijden);
                    rondeView.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Er zijn geen wedstrijden die je kan beoordelen");
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (nieuwsteWedstrijden.Count == 0)
                {
                    frmPouleCreate rondeView = new frmPouleCreate(huidigeRonde);
                    rondeView.ShowDialog();
                    RefreshWindow();
                }
                else
                {
                    MessageBox.Show($"De eerste ronde is al aangemaakt. Maak deze eerst ongedaan.");
                }
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            if (UserSession.Instance.IsLoggedIn)
            {
                // Verwijderen van alle wedstrijden
                WedstrijdController controller = new WedstrijdController();
                controller.DeleteAll();
                RefreshWindow();
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Log in als beheerder.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
