using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Car
    {
        public string Brand { get; }
        public string RegistrationNumber { get; }
        public int Year { get; }
        public int Km { get; }


        public Car(string brand, string registrationNumber, int year, int km)
        {
            Brand = brand;
            RegistrationNumber = registrationNumber;
            Year = year;
            Km = km;
        }

    }
}
