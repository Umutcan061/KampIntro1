using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();





        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int ıd, string firstName, string lastname, string city)
        {
            Id = ıd;
            FirstName = firstName;
            Lastname = lastname;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }
}
