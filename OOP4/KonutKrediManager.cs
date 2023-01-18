using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı");
        }

        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }
    }
}
