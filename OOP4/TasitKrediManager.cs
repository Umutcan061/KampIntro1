﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı");
        }

        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }
    }
}
