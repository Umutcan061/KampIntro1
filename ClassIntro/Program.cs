using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Umutcan Çalık";
            kurs2.İzlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Eğitmen = "Reis Demiroğ";
            kurs3.İzlenmeOrani = 6;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Eğitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }


}
