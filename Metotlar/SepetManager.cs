using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(urun.Adi+": Sepete eklendi ");



        }
        public void ekle2(string urunAdi,string aciklama,double fiyat) 
        {
            Console.WriteLine(urunAdi + ": Sepete eklendi ");
        }




    }
}
