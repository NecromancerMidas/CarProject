using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class CarDealership
    {
        private string _name;
        private string _adress;
        public List<Car> Cars { get; }

        public CarDealership()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            var newCar = car;
            Cars.Add(car);
        }

        public void RemoveCar(string registrationNumber)
        {
            var tempList = new Car[Cars.Count];
            Cars.CopyTo(tempList);
            
            foreach (var car in tempList.Where(car => car.RegistrationNumber == registrationNumber)) //not really required but very neat.
            {
                Cars.Remove(car);
            }
        }

        public List<Car> ListOlderCars(int year)
        {
            var templist = new List<Car>();
            Console.WriteLine(@$"
List of cars older than {year}");
           foreach (var car in Cars.Where(car => car.Year > year))
           { 
               Console.WriteLine(@$"Brand:{car.Brand} RegistrationNumber:{car.RegistrationNumber} Year:{car.Year} Km:{car.Km}
");
               templist.Add(car);
           }
           return templist;
        }

        public List<Car> ListMoreKm(int Km)
        {
            var templist = new List<Car>();
            Console.WriteLine($@"
List of cars with Km more than {Km}");
            foreach (var car in Cars.Where(car => car.Km > Km))
            {
                Console.WriteLine(@$"Brand:{car.Brand} RegistrationNumber:{car.RegistrationNumber} Year:{car.Year} Km:{car.Km}
");
                templist.Add(car);
            }


            return templist;
        }
        
    }
}
