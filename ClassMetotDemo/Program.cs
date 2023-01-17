using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id= 1;
            musteri1.FirstName = "Umutcan";
            musteri1.LastName = "Çalık";
            musteri1.Age = 30;  

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.GetAll(musteri1);
            musteriManager.Remove(musteri1);


        }
    }
}
