using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu() {
                Id = 1,
                Adi = "okkes",
                Soyadi="sen",
                DogumTarihi = "12.06.1990",
                TcNo = "22222222222"
            };
            OyuncuManager oyuncuManager = new OyuncuManager();
            bool karar=oyuncuManager.Dogrula(oyuncu1);
            if (karar)
            {
                oyuncuManager.Ekle(oyuncu1);
            }
            else {
                Console.WriteLine("Kayıt eklenemedi hata oluştu.");
            }

            Oyun oyun1 = new Oyun
            {
                Id = 1,
                Adi = "Uçak",
                Fiyati = 250
            };

            Kampanya kampanya1 = new Kampanya()
            {
                Id = 1,
                Oyun = oyun1.Adi,
                KampanyaAdi = "Büyük İndirim",
                IndirimOrani = 0.40
            };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Ekle(kampanya1);

            OyunManager oyunManager = new OyunManager();
            oyunManager.OyunSatis(oyuncu1, oyun1, kampanya1);  
            Console.ReadKey();
        }
    }
}
