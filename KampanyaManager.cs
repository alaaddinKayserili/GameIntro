using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    class KampanyaManager:IKampanyaManager
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Guncelle()
        {
            Console.WriteLine("Kampanya guncellendi");
        }

        public void Sil()
        {
            Console.WriteLine("Kampanya silindi.");
        }
    }
}
