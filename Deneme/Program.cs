using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> myDictionary= new MyDictionary<int>();
            myDictionary.Add(1,1);
            myDictionary.Add(2,2);  
            myDictionary.Add(3,3);
            Console.WriteLine(myDictionary[][1]);



        }
    }
}
