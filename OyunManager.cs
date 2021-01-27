using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    class OyunManager
    {
        public void OyunSatis(Oyuncu person, Oyun game, Kampanya campaign)
        {
            double indirimliFiyat = game.Fiyati - (game.Fiyati * campaign.IndirimOrani);
            Console.WriteLine(game.Adi + " adlı oyun " + person.Adi + " kişisine satıldı." + " TUTAR:" + indirimliFiyat + "TL");
        }
    }
}
