using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem= new DortIslem();
            dortIslem.toplama(8,9);
            dortIslem.cikar(1000,95);
            dortIslem.carp(1000,45);
            dortIslem.bol(45,5);
        }
    }
}
