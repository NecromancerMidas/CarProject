

namespace CarProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var carDealership1 = new CarDealership();
            var car1 = new Car("Brand1","Lol123",2020,25000);
            var car2 = new Car("Brand2", "Lol124", 2050, 27000);
            var car3 = new Car("Brand3", "Lol125", 2010, 21000);
            carDealership1.AddCar(car1);
            carDealership1.AddCar(car2);
            carDealership1.AddCar(car3);
            var carList = carDealership1.ListMoreKm(22000);
            var carList2 = carDealership1.ListOlderCars(2020);
            carDealership1.RemoveCar("lol123");



        }



    }



}

