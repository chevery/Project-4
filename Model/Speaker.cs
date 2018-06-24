using System;
using System.Collections.Generic;
using System.Text;

namespace KillMyself.Model
{
    public class Speaker
    {

        public string SpeakerName { get; set; }

        public string Topic { get; set; }

        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }

        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>()
            {
                new Speaker(){ SpeakerName="Info", Topic="App", ShortDescription="Deze app is gemaakt voor mensen die geïnteresseerd zijn in musea. In de app kunt u zien welke tentoonstellingen binnenkort zijn en u kunt ook zien welke musea in de buurt zijn. Bij musea kunt u zien welke musea er zijn met de trefwoorden", ImageUrl="" },

                new Speaker(){ SpeakerName="Gebruiksaanwijzing", Topic="Hulp", ShortDescription="Als u bij Musea zoekt naar musea dan kunt u de titel opzoeken of de trefwoorden. Als u op een musea klikt dan kunt u extra informatie erover vinden en de openingstijden en naar de website gaan van de musea."},

                new Speaker(){ SpeakerName="Credits", Topic="The end", ShortDescription= "De ontwikkelaars zijn: Chevery, Sheriyar & Vincent.", ImageUrl=""}
            };
            return speakers;
        }
    }
}
