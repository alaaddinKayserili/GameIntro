using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    class OyuncuManager:IOyuncuManager

    {
        public void Ekle(Oyuncu person)
        {
            Console.WriteLine(person.Adi+" "+person.Soyadi+" oyuncu olarak eklendi");
        }

        public void Guncelle()
        {
            Console.WriteLine("oyuncu bilgisi guncellendi.");
        }

        public void Sil()
        {
            Console.WriteLine("oyuncu bilgisi silindi.");
        }
        public bool Dogrula(Oyuncu person)
        {
            if (person.TcNo != null && person.Adi != null && person.Soyadi != null && person.DogumTarihi != null)
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
    }
}
