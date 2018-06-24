﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KillMyself.Viewmodel
{
    public class FilterViewModel
    {
        private Product _oldProduct;


        public ObservableCollection<Product> Products {get; set; }
        public FilterViewModel()

        {
            Products = new ObservableCollection<Product>
            {


                new Product()
                {
                 Title = "Kinderen", Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 11:00 – 17:00 \n Woensdag: 11:00 – 17:00 \n Donderdag: 11:00 – 17:00\n Vrijdag: 11:00 – 17:00\n Zaterdag: 11:00 – 17:00", Webs ="https://www.boijmans.nl/",  Title2 = "\n Museum Booijmans van Beuningen, Rotterdam",Name ="Museum Boijmans van Beuningen", Detail="Rembrand, Gouden tijd, Rotterdam, Surrealisme", Imageurl="Boijmans.jpg", Overview="\n Museum Boijmans Van Beuningen is een museum voor beeldende kunst, gelegen aan het Museumpark te Rotterdam. \n \n  Het museum toont creaties op het gebied van beeldende kunst, toegepaste kunst en design.\n De collectie tekeningen is een van de belangrijkste ter wereld.\n Boijmans Van Beuningen biedt een overzicht van Nederlandse en Europese kunst, van de vroege middeleeuwen tot in de 21e eeuw. \n \n Te zien zijn onder andere de schilderijen 'De kleine toren van Babel' uit 1563 van Bruegel, 'De drie Maria's' van Jan van Eyck, en 'Titus' van Rembrandt, maar ook de 'Lippenbank' van Salvador Dalí. \n \n De instelling behoort tot de top van de Nederlandse kunstmusea."
                },
                new Product()
                {
                    Title = "Volwassenen",
                 Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 10:00 – 17:00 \n Woensdag: 10:00 – 17:00 \n Donderdag: 10:00 – 17:00\n Vrijdag: 10:00 – 17:00\n Zaterdag: 10:00 – 17:00",  Webs="https://www.catharijneconvent.nl/", Title2 ="\n Museum Catharijneconvent, Utrecht",Name ="Museum Catharijneconvent", Detail="Religie, Middeleeuwse kunst, Vroegrenaissance, Utrecht", Imageurl="Catharijneconvent.jpg", Overview="\n Museum Catharijneconvent is gevestigd in een middeleeuws klooster uit de 15e eeuw. \n \n Het is gewijd aan het heden en verleden van het christendom in Nederland. \n \n Aan de hand van eeuwenoude en hedendaagse kunst en diverse andere objecten wordt het verhaal van het christendom verteld. \n \n De vaste collectie is zeer divers en bestaat onder meer uit schilderijen van meesters als Rembrandt, goud en zilver, beelden van heiligen, Mariabeelden, oude manuscripten, rozenkransen en videokunst."
                },
                new Product()
                {
                     Title="Amsterdam",
                Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 10:00 – 17:00 \n Woensdag: 10:00 – 17:00 \n Donderdag: 10:00 – 17:00\n Vrijdag: 10:00 – 17:00\n Zaterdag: 10:00 – 17:00",   Webs="https://www.maritiemmuseum.nl/", Title2 = "\n Maritiem Museum, Rotterdam",Name ="Maritiem Museum", Detail="Kinderen, VOC, Knappe Koppen, Offshore Experience, Kindvriendelijk, Rotterdam", Imageurl="Maritiem.jpg", Overview="\n In het Maritiem Museum Rotterdam ontdek je de enorme invloed van de maritieme wereld op ons dagelijks leven. \n \n Ga mee op reis door ons maritieme heden en verleden in eigentijdse tentoonstellingen voor grote én kleine avonturiers. \n \n Luister naar verhalen, bewonder topstukken uit onze vooraanstaande collectie of doe mee aan een van de vele activiteiten. \n \n Het museum ligt in de oudste en grootste museumhaven van Nederland waar je op historische schepen en kranen beleeft hoe de wereldhaven Rotterdam op déze plek begon."
                },
                new Product()

                {
                    Title ="Den Haag",
                 Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 11:00 – 17:00 \n Woensdag: 11:00 – 17:00 \n Donderdag: 11:00 – 17:00\n Vrijdag: 11:00 – 17:00\n Zaterdag: 11:00 – 17:00",   Webs="https://www.escherinhetpaleis.nl/",Title2 = "\n Escher in Het Paleis",Name ="Escher in Het Paleis", Detail="Perspectief, Grafische kunst, Metamorfose, Den Haag", Imageurl="Escher.jpg", Overview="\n De Nederlandse Kunstenaar Maurits Cornelis Escher (1898 – 1972) is een van de bekendste grafische kunstenaars ter wereld. \n Tot op de dag van vandaag fascineert hij door zijn spel met perspectief, ruimte en werkelijkheid. \n \n De hoogtepunten uit zijn oeuvre zijn te zien in Escher in Het Paleis."
                },
                 new Product()
                {
                    Title ="Rotterdam",
                  Openings = "\n Zondag: 09:00 – 20:00 \n Maandag: 09:00 - 20:00 \n Dinsdag: 09:00 - 20:00 \n Woensdag: 09:00 - 20:00 \n Donderdag: 09:00 - 20:00 \n Vrijdag: 09:00 - 20:00 \n Zaterdag: 09:00 - 20:00",  Webs="https://www.madurodam.nl/nl",Title2 = "\n Madurodam, Den Haag",Name ="Madurodam" , Detail="Klein en groot, Kinderen, Miniatuur, Den Haag", Imageurl="Madurodam.jpg", Overview="\n In Madurodam ontdek je waar een klein land groot in is. \n \n Stap in de schoenen van DJ Armin van Buuren en mix bij de DJ Tafel je eigen beats, leer vliegen op Schiphol en laad een schip met containers in de haven van Rotterdam. \n \n Vervelen is hier geen optie!"
                },
                 new Product()
                {
                     Title ="Utrecht",
                  Openings = "\n Zondag: 10:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 10:00 – 17:00 \n Woensdag: 10:00 – 17:00 \n Donderdag: 10:00 – 17:00\n Vrijdag: 10:00 – 17:00\n Zaterdag: 10:00 – 17:00", Webs="https://www.spoorwegmuseum.nl/", Title2 = "\n Het Spoorwegmuseum, Utrecht",Name ="Het Spoorwegmuseum", Detail="Spoorweg, Geschiedenis, Technologie, Utrecht", Imageurl="Spoorweg.jpg", Overview="\n Het Spoorwegmuseum is gevestigd in het Maliebaanstation uit 1874. \n \n Het museum is een museaal attractiepark waar het verhaal verteld wordt van bijna 175 jaar spoorwegen in Nederland. \n \n De collectie van het museum bestaat onder meer uit stoomlocomotieven, diesellocomotieven, elektrische locomotieven, treinstellen, rijtuigen en trams. \n \n Het museum is opgedeeld in verschillende werelden. \n \n Via deze werelden maakt de bezoeker een reis door de geschiedenis van spoorwegen. \n \n De presentatie is gericht op een groot publiek met kinderen."
                },
                 new Product()
                {
                     Title ="Kunst",
                   Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 11:00 – 17:00 \n Woensdag: 11:00 – 17:00 \n Donderdag: 11:00 – 17:00\n Vrijdag: 11:00 – 17:00\n Zaterdag: 11:00 – 17:00",Webs="https://centraalmuseum.nl/bezoeken/locaties/rietveld-schroederhuis/", Title2 = "\n Rietveld Schröderhuis, Utrecht",Name ="Rietveld Schröderhuis", Detail="Historisch huis, design, toegepaste kunst, Utrecht", Imageurl="Rietveld.jpg", Overview="\n Het Rietveld Schröderhuis is een door Gerrit Rietveld in 1924 ontworpen huis. \n \n Het huis is compleet ontworpen volgens de ideeën van de kunstbeweging De Stijl en staat sinds 2000 op de Werelderfgoedlijst van UNESCO. \n \n Bezoekers ontdekken onder meer hoe plooibaar en multifunctioneel in het bijzonder de centrale 'huiskamer' op de eerste verdieping is. \n \n Het Centraal Museum heeft de woning in beheer en verzorgt rondleiding door de woning."
                },
                new Product()
                {
                    Title ="Middeleeuwen",
                 Openings = "\n Zondag: 09:00 - 18:00 \n Maandag: 09:00 - 18:00 \n Dinsdag: 09:00 - 18:00 \n Woensdag: 09:00 - 18:00 \n Donderdag: 09:00 - 21:00 \n Vrijdag: 09:00 - 21:00 \n Zaterdag: 09:00 - 18:00",   Webs="https://www.rijksmuseum.nl/",Title2 = "\n Rijksmuseum, Amsterdam",Name ="Rijksmuseum", Detail="Renaissance, middeleeuwen, Nederland, Amsterdam", Imageurl="Rijksmuseum.jpg", Overview="\n Het Rijksmuseum is gevestigd in een uniek historisch monumentaal gebouw uit 1885 van architect P.J.H. Cuypers. \n \n Het museum is gewijd aan de Nederlandse kunst en Nederlandse geschiedenis. \n \n De collectie wordt getoond in meer dan tweehonderd zalen en bestaat onder meer uit werken van Nederlandse meesters als Rembrandt van Rijn, Johannes Vermeer en Frans Hals. \n \n Naast schilderkunst uit de Middeleeuwen de 18e eeuw en de 19e eeuw, stelt het museum ook beeldhouwkunst, kunstnijverheid en moderne kunst ten toon. \n \n Het bekendste werk in de collectie is De Nachtwacht van Rembrandt van Rijn."
                },
                new Product()
                {
                    Title ="K",
                  Openings = "\n Zondag: 10:00 – 17:00 \n Maandag: 10:00 - 18:00 \n Dinsdag: 10:00 – 17:00 \n Woensdag: 10:00 – 17:00 \n Donderdag: 10:00 – 17:00\n Vrijdag: 10:00 – 17:00\n Zaterdag: 10:00 – 17:00",  Webs="https://www.foam.org/nl/home",Title2 = "\n FOAM, Amsterdam",Name ="FOAM", Detail="Fotografie, vele exposities, mode, Amsterdam", Imageurl="Foam.jpg", Overview="\n Foam is een fotografiemuseum voor fotografie in al haar gedaanten. \n \n  Het museum presenteert wisselende tentoonstellingen waarin diverse fotografische genres worden getoond, van mode tot documentair en van historisch tot eigentijds. \n \n In het museum wordt zowel werk van beroemde fotografen als van jong talent getoond. Grote langdurige exposities worden afgewisseld met kleine, snel wisselende exposities."
                },
                new Product()
                {
                    
                 Openings = "\n Zondag: 11:00 – 17:00 \n Maandag: Gesloten \n Dinsdag: 10:00 – 17:00 \n Woensdag: 10:00 – 17:00 \n Donderdag: 10:00 – 17:00\n Vrijdag: 10:00 – 17:00\n Zaterdag: 10:00 – 17:00",    Webs="https://www.kunsthal.nl/nl/",Title2 = "\n Kunsthal Rotterdam, Rotterdam", Name ="Kunsthal Rotterdam", Detail="Rotterdam, Hyperrealisme, kinetische kunst", Imageurl="Kunsthal.jpg", Overview="\n De Kunsthal is een expositieruimte zonder eigen collectie. \n \n  Praktisch gezien is het daarom geen museum. In plaats daarvan organiseert de Kunsthal wisseltentoonstellingen op het gebied van kunst en cultuur. \n \n  Door de grote oppervlakte is het mogelijk ongeveer vijf exposities tegelijk te laten plaatsvinden. \n \n Het museum heeft dan ook ongeveer 25 verschillende exposities per jaar."
                },

            };
        }

        public void HideorShowProduct(Product product)
        {
            if (_oldProduct == product)
            {
                //Click twice on the same item will hide it
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    //hide previous selected item
                    product.IsVisible = false;
                    UpdateProducts(product);
                }
                //show selected item
                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index,product);
        }
    }
}
