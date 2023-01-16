using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Adi = "Çilek";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya çileği";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Elma";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Gümüşhane Elması";
            urun2.Id = 2;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler) {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }
            Console.WriteLine("-----------Metotlar---------");
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.ekle2("Armut","Yeşil Armut",12);

        }
    }
}
