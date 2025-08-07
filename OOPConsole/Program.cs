using System;

namespace OOPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Program2 name1 = new Program2();
            // Program2 name2 = new Program2();
            // name1.Hello("Santiago");
            // name2.Hello("Taguro");

            Vehicle kotse1 = new Car();
            kotse1.Travel();
            kotse1.Stop();

        }
    }

    public abstract class Vehicle
    {
        public abstract void Travel();
        public abstract void Stop();

    }
    public class Car : Vehicle
    {
        public override void Travel()
        {
            Console.WriteLine("umaandar sa lupa");
        }
        public override void Stop()
        {
            Console.WriteLine("huminto sa lupa");
        }
    }
}
