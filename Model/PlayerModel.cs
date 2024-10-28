/*
    Naam:   Lucas Matthijsse, René Kok, Jaimy Mathon
    Klas:   IO1S2AV
    Datum:  30-5-2024

    Omschrijving:   PlayerModel
 */

namespace T8_PraktijkProject.Model
{
    public class PlayerModel
    {
        // Properties declareren
        public int SpelerId { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Disciplines { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Afbeelding { get; set; }

        // Deze overriden zodat wanneer de model in een lijst staat hij een tweede als een duplicate ziet ipv een nieuwe player
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PlayerModel other = (PlayerModel)obj;
            return SpelerId == other.SpelerId;
        }

        public override int GetHashCode()
        {
            return SpelerId.GetHashCode();
        }

        // Constructor
        public PlayerModel()
        {
        }
    }
}
