using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri) 
        {
            Console.WriteLine("Müşteri başarıyla eklendi.");
        
        }
        public void GetAll(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi");
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi."  );
        }




    }
}
