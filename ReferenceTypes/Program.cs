using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            int[] sayilar = new int[] { 1,2,3,4,5 };
            int[] sayilar2 = new int[] {10,20,30,40,50 };

            sayilar = sayilar2;
            sayilar2[0] = 10000;

            Console.WriteLine(sayilar[0]);

            Person person1= new Person();
            Person person2= new Person();
            person1.FirstName = "Umut";
            person2 = person1;
            person1.FirstName = "SUde";
            Console.WriteLine(person2.FirstName);


            Customer customer= new Customer();
            Employee employee= new Employee();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
    class Customer : Person 
    {
        public string KrediNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    
}
