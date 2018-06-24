using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KillMyself
{
    public class Tentoonstellingenclass
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Imageurl { get; set; }
        public string Overview { get; set; } 
        public string Title2 { get; set; }
        public string Webs { get; set; }
        public List<Tentoonstellingenclass> GetTentoonstellingenclasses()
        {
            List<Tentoonstellingenclass> tent = new List<Tentoonstellingenclass>()
            {
                new Tentoonstellingenclass()
                {
                Webs = "https://www.kunsthal.nl/nl/plan-je-bezoek/tentoonstellingen/viktorrolf-fashion-artists-25-years/", Title2= "\n Kunsthal Rotterdam, Rotterdam",  Name ="Viktor&Rolf – Fashion Artists 25 Years", Detail="27 Mei - 30 Sep", Imageurl="Viktor&Rolf.jpg", Overview="\n \n De tentoonstelling presenteert een aantal van de meest sublieme en innovatieve werken van het ontwerpduo, waaronder circa 45 werken uit hun haute couture collecties, toneelkostuums voor ballet en opera evenals eerdere ontwerpen uit Viktor&Rolf’s archieven en uit collecties van (inter)nationale musea. \n \n Ook is een selectie van hun work-in-progress serie ‘Dolls’ − replica’s van antieke poppen gekleed in de meest iconische ontwerpen van de modekunstenaars − te zien. \n \n Daarnaast zijn er speciale stukken, zoals de kostuums die zij in 2016 voor Madonna hebben gemaakt voor haar inzamelingsconcert in Miami Art Basel, en nieuwe werken uit de nieuwste collecties, ‘Boulevard of Broken Dreams’ en ‘Action Dolls’, die nooit eerder zijn vertoond."
                },
                new Tentoonstellingenclass()
                {
                   Webs ="https://www.kunsthal.nl/nl/plan-je-bezoek/tentoonstellingen/poetry-artgallerytour2018/", Title2 = "\n Kunsthal Rotterdam, Rotterdam", Name ="Poetry of a Nation", Detail="27 Mei - 3 Jun", Imageurl="nation.jpg", Overview=" \n \n Het Rotterdamse kunstenaarscollectief KAMP HORST staat bekend om zijn intense schilderwerken met stripachtige composities, waarin absurde humor en wringende combinaties van personen, dieren en objecten het eindresultaat dicteren. \n \n  Voor de muurschildering in de Kunsthal sluit KAMP HORST aan op het festivalthema Poetry of a Nation / the Nation of Poetry. \n \n In een tijd waarin er nadruk ligt op wat een volk, een natie uniek en eigen maakt, koesteren velen het nationalisme als noodzakelijk voor het behoud van de identiteit. \n \n Anderen zien hier juist een keurslijf in en een sentiment dat de samenleving verdeelt. \n \n Binnen dit thema creëert KAMP HORST een wereld die raakvlakken heeft met de werkelijkheid, maar door middel van inside jokes en absurditeit resulteert in een compleet onverwacht en prikkelend beeld."
                },
                new Tentoonstellingenclass()
                {
                 Webs="https://www.nederlandsfotomuseum.nl/tentoonstelling/martin-schoeller-big-heads/",   Title2 = "\n Nederlands Fotomuseum, Rotterdam ", Name ="Martin Schoeller – Big Heads", Detail="19 Mei - 2 Sep", Imageurl="MartinSchoeller.jpg", Overview="\n \n Het Nederlands Fotomuseum brengt met Martin Schoeller één van de grootste portretfotografen van dit moment voor het eerst naar ons land. \n \n Schoeller brak internationaal door met de iconische serie Close Up, waar hij al meer dan twintig jaar doorlopend aan werkt.\n In deze serie portretteert Schoeller zijn subject van zeer dichtbij: altijd met dezelfde lens, dezelfde belichting en vanuit dezelfde hoek. \n \n  Hij heeft voor deze serie de groten der aarde voor zijn camera weten te krijgen, waaronder George Clooney, Lady Gaga, Angelina Jolie, Angela Merkel, Jack Nicholson en Barack Obama.\n \n  Naast de ‘big head’ portretten is ook werk uit drie andere projecten van Schoeller te zien. \n \n  Tijdens de opening op 18 mei wordt, in aanwezigheid van Martin Schoeller, een nieuwe ‘big head’ van een wereldster van Nederlandse komaf onthuld."
                },
                new Tentoonstellingenclass()
                {
                Webs="https://www.oba.nl/agenda.modemuze.html?gclid=Cj0KCQjwmPPYBRCgARIsALOziAMOKqe8Tm3Viuo8etXrMFpfomnbne17wfregvDYnZWZ09RYcvw4fz8aAkMHEALw_wcB",    Title2 = "\n Nederlands Fotomuseum, Rotterdam ",Name ="Modemuze@OBA – Innovation", Detail="16 Mei - 2 Sep", Imageurl="modemuze.jpg" , Overview="\n \n Heel modeminnend Nederland kan zijn hart ophalen in de Centrale OBA waar Modemuze op 17 mei de expositie ‘Modemuze@OBA: Innovation’ opent. \n \n  Na de succesvolle eerste editie in de OBA in 2017, komt Modemuze wederom met een verrassende tentoonstelling met een uitgebreid en divers evenementenprogramma. \n \n Laat je inspireren door zowel historische kleding als hedendaagse outfits van jonge ontwerpers, geselecteerd door veertien musea en vier verzamelaars!"
                },
                 new Tentoonstellingenclass()
                {
                 Webs="http://www.galerie-ra.nl/nl/therese-hilbert-patricia-domingues",   Title2 = "\n Galerie Ra, Amsterdam ",Name ="Therese Hilbert – Eruption" , Detail="12 Mei - 23 Jun", Imageurl="Therise.jpg" , Overview="\n \n Therese Hilbert wordt al decennialang gefascineerd door vulkanen; door hun specifieke vorm die een diepe krater omhult als een mantel, en door hun dreigende onvoorspelbaarheid en ontembaarheid. \n \n Ze zijn verbonden met de kleuren vuurrood, zwavelgeel, en het zwart van gestolde lava, ingebed in vele schakeringen grijs.\n In de loop der jaren bezocht Therese vele vulkanen. \n \n Gesteenten die ze daar vond, vooral het vulkanisch glas obsidiaan, bracht ze mee naar huis om ze later in haar sieraden te verwerken."
                },
                 new Tentoonstellingenclass()
                {
                 Webs="http://www.zerp.nl/territory.html",   Title2="\n ZERP Galerie, Rotterdam ",Name ="Territory", Detail="6 Mei - 3 Jun", Imageurl="Territory.jpg", Overview="\n \n Van 6 mei t/m 3 juni 2018 presenteert ZERP Galerie Rotterdam de groepstentoonstelling ‘Territory’. \n \n  Kunstenaars Madison, Jelle Rietveld, Marcha van den Hurk, Arjan Post en Paul Buijs onderzoeken de dwarsverbanden tussen identiteit, perceptie en leefomgeving. \n \n Centraal staan territoria in letterlijke en figuurlijke zin: van droomwerelden en subculturen tot dagelijkse leef-omgevingen."
                },
                 new Tentoonstellingenclass()
                {
                  Webs="https://www.fotomuseumdenhaag.nl/nl/tentoonstellingen/jan-banning", Title2="\n Fotomuseum Den Haag, Den Haag ", Name ="Jan Banning", Detail="5 Mei - 2 Sep", Imageurl="JanBanning.jpg", Overview="\n \n Fotomuseum Den Haag toont deze zomer het eerste oeuvreoverzicht van de Nederlandse kunstenaar-fotograaf Jan Banning (1954). \n \n Hij studeerde Sociale en Economische Geschiedenis voordat hij begon met fotograferen. \n \n De invloed van die studie zien we terug in zijn werk. \n \n Banning schept met zijn foto’s een beeld van de sociaal-politieke omstandigheden in verschillende landen. \n \n  Hij reist de hele wereld over om abstracte begrippen als de staatsmacht en de consequenties van oorlog te visualiseren. \n \n Een van zijn bekendste series is Troostmeisjes (2010), een reeks portretten van Indonesische vrouwen die tijdens de Tweede Wereldoorlog door het Japanse leger werden gedwongen als seksslaaf te werken. \n \n Voor Bureaucratics (2003-2007) fotografeerde hij ambtenaren in acht landen wereldwijd."
                },
                new Tentoonstellingenclass()
                {
                 Webs="http://www.museumhetsterkenhuis.nl/nu-te-zien",   Title2="\n Gemeentemuseum Het Sterkenhuis, Bergen ",Name ="Mooie plooien", Detail="29 Apr - 28 Okt", Imageurl="plooien.jpg", Overview="\n \n Museum Het Sterkenhuis beschikt over een unieke collectie textiel. \n \n Dit is grotendeels te danken aan Marie van Reenen – de grondlegster van de collectie van Het Sterkenhuis. \n \n De mooiste objecten uit de textielverzameling worden in de aankomende seizoenstentoonstelling getoond. \n \n Vanaf 29 april presenteert het museum de mooiste historische plooistukken vanaf 1750 in samenhang met de collectie-opstelling en de stijlkamer. \n \n Ook is er  aandacht voor de vroegste voorbeelden uit geschiedenis.  \n \n Aan de hand van gereedschappen en replica’s ontdek je hoe er tweeduizend jaar geleden al werd geplooid!"
                },
                new Tentoonstellingenclass()
                {
                 Webs="https://www.friesmuseum.nl/te-zien-en-te-doen/tentoonstellingen/escher-op-reis/",   Title2="\n Fries Museum, Leeuwarden ",Name ="Escher op reis", Detail="28 Apr - 28 Okt", Imageurl="Escher.jpg", Overview="\n \n De tentoonstelling is opgezet als een driedimensionale biografie, waarbij je Escher persoonlijk leert kennen en in zijn voetsporen treedt. \n \n  De reis begint in 1898 toen Maurits Cornelis werd geboren in het stadspaleis aan de Grote Kerkstraat waar nu Keramiekmuseum Princessehof gevestigd is. \n \n De locaties waar hij verbleef waren van grote invloed op zijn leven. \n \n Van het grauwe platte Nederland van de jaren tien van de twintigste eeuw tot de zon en de bergen van de Méditerranée. \n \n In Italië bracht Escher zijn gelukkigste jaren door. \n \n Bij het zien van de serie prenten van Italiaanse dorpjes en zijn donkere werken van Rome bij nacht ontdek je dat hij onder invloed van de prachtige landschappen begon te experimenteren met opvallende perspectieven en beeldcompilaties. \n \n Terug in Nederland verwerkte Escher al deze ervaringen en indrukken tot complexe mathematische beelden en onmogelijke werelden." 
                },
                new Tentoonstellingenclass()
                {
                  Webs="http://www.mikstmediawoudrichem.nl/actueel.html", Title2="\n Mikst Media Woudrichem ", Name ="Mieke Klaase – Als een rode draad", Detail="28 Apr - 2 Jun", Imageurl="MiekeKlaase.jpg", Overview="\n \n Het schilderen is voor mij een proces waarbij vooral de zoektocht en de ontdekkingen me aanspreken. \n \n Ik werk spontaan op het doek, laag over laag om een interessante huid te laten ontstaan waarbij de kleuren een belangrijk beeldelement blijven. \n \n Ik werk laag over laag totdat het werk oproept wat ik probeer weer te geven. \n \n Op verschillende manieren probeer ik invloed uit te oefenen op het werk of laat ik juist gebeuren wat gebeurt. \n \n Spontane vondsten op het doek kunnen het geheel net zo versterken als doorwerkte structuren. \n \n Ik volg mijn intuïtie en neem steeds afstand om te bekijken wat het werk vraagt: is er een evenwicht tussen spanning en rust, versterken vorm en kleur elkaar, is het boeiend. \n \n Ik ga door totdat de sfeer me treft, het werk kan blijven verrassen en boeien; het is “af”."
                }, 


            };
            return tent;
        }
        

    }
}
