/*
    Naam:   Lucas Matthijsse, René Kok, Jaimy Mathon
    Klas:   IO1S2AV
    Datum:  30-5-2024

    Omschrijving:   WedstrijdModel
*/

namespace T8_PraktijkProject.Model
{
    public class WedstrijdModel
    {
        // Fields
        private int wedstrijdId;
        private int wedstrijdNummer;
        private int pouleId;
        private DateTime tijd;
        private string ring;
        private int ronde;
        private PlayerModel deelnemer1;
        private int puntenDeelnemer1;
        private PlayerModel deelnemer2;
        private int puntenDeelnemer2;

        // Properties
        public int WedstrijdId
        {
            get { return wedstrijdId; }
            set { wedstrijdId = value; }
        }

        public int WedstrijdNummer
        {
            get { return wedstrijdNummer; }
            set { wedstrijdNummer = value; }
        }

        public int PouleId
        {
            get { return pouleId; }
            set { pouleId = value; }
        }

        public DateTime Tijd
        {
            get { return tijd; }
            set { tijd = value; }
        }

        public string Ring
        {
            get { return ring; }
            set { ring = value; }
        }

        public int Ronde
        {
            get { return ronde; }
            set { ronde = value; }
        }

        public PlayerModel Deelnemer1
        {
            get { return deelnemer1; }
            set { deelnemer1 = value; }
        }

        public int PuntenDeelnemer1
        {
            get { return puntenDeelnemer1; }
            set { puntenDeelnemer1 = value; }
        }

        public PlayerModel Deelnemer2
        {
            get { return deelnemer2; }
            set { deelnemer2 = value; }
        }

        public int PuntenDeelnemer2
        {
            get { return puntenDeelnemer2; }
            set { puntenDeelnemer2 = value; }
        }

    }
}
