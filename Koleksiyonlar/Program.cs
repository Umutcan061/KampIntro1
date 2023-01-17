using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
     class Program
    {
        static void Main(string[] args)  
        {
            //string[] isimler = new string[] { "Ahmet", "Mehmet", "Ece" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            List<string> isimler2 = new List<string> {"Ahmet","Mehmet","Ali" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Umutcan");
            Console.WriteLine(isimler2[3]);

        }
    }
}
