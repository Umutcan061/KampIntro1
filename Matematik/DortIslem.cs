using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
     class DortIslem
    {
        public void toplama(int sayi1,int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);

        }
        public void cikar(int sayi1,int sayi2) 
        {
            int sonuc=sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }
        public void carp(int sayi1,int sayi2) 
        {
            int sonuc=sayi1*sayi2;
            Console.WriteLine(sonuc);
        }
        public void bol(int sayi1,int sayi2) {
            
            int sonuc=sayi1/sayi2;
            Console.WriteLine(sonuc);
        }

    }
}
