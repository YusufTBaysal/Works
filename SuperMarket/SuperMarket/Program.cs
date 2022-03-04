using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 25;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            SepetManager sepet = new SepetManager();

            sepet.Ekle(urun1);
            Console.WriteLine("----------------------------------------------");
            sepet.Ekle(urun2);

            Console.ReadKey();
        }
    }
}
