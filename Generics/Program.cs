using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            MyList<int> plakalar = new MyList<int>();
            plakalar.Add(1);
            plakalar.Add(2);
            plakalar.Add(3);
            Console.WriteLine(plakalar[0];



        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array= new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array= new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _array.Length; }
        }




    }

 
        

    }



