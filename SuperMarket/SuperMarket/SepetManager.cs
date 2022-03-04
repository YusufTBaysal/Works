using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urun.Adi);
            Console.WriteLine("Eklenen ürünün fiyatı : " + urun.Fiyat);
            Console.WriteLine("Eklenen ürünün açıklaması : " + urun.Aciklama);
        }
    }
}
