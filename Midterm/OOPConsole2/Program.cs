using System;
namespace OOPConsole2
{
    abstract class Vehicle
    {
        protected string brand;
        protected int hoursRented;
        public void SetData(string brand, int hoursRented)
        {
            this.brand = brand;
            this.hoursRented = hoursRented;
        }
        public abstract void DisplayInfo();
        public abstract int CalculateRental();

    }
    class Car : Vehicle
    {
        private int rate = 1300;
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Brand: {brand}, Hours Rented: {hoursRented}");
            Console.WriteLine($"Car Rental Cost: Php {CalculateRental()}");
        }
        public override int CalculateRental()
        {
            return hoursRented * rate;
        }
    }
    class Motorcycle : Vehicle
    {
        private int rate = 500;
        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle Brand: {brand}, Hours Rented: {hoursRented}");
            Console.WriteLine($"Motorcycle Rental Cost: Php {CalculateRental()}");
        }
        public override int CalculateRental()
        {
            return hoursRented * rate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car();
            car1.SetData("Toyota", 5);
            car1.DisplayInfo();

            Vehicle car2 = new Car();
            car2.SetData("Ferarri", 8);
            car2.DisplayInfo();

            Vehicle motorcycle1 = new Motorcycle();
            motorcycle1.SetData("Yamaha", 3);
            motorcycle1.DisplayInfo();

            Vehicle motorcycle2 = new Motorcycle();
            motorcycle2.SetData("Mio", 6);
            motorcycle2.DisplayInfo();
        }
    }
}