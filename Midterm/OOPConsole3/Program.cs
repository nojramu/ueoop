using System;
namespace OOPConsole3
{
    class Program
    {
        static void Main()
        {
            Shape iskwer = new Square("Yellow", 10);
            iskwer.DisplayInfo();
            iskwer.Destroy(); // Manual cleanup
            
            Shape bilog = new Circle("Green", 5);
            bilog.DisplayInfo();
            bilog.Destroy(); // Manual cleanup
            
            Console.WriteLine("Program ending...");
        }
    }
    public abstract class Shape
    {
        public string? color;
        public double length;

        public Shape(string color, double length) {
            this.color = color;
            this.length = length;
            Console.WriteLine("Shape created"); 
        }
        
       ~Shape(){
            Console.WriteLine("shape destroyed");
       }
        
        public void Destroy()
        {
            Console.WriteLine("shape destroyed");
        }
        
        public abstract double GetArea();
        public abstract void DisplayInfo();
    }

    public class Square : Shape
    {
        public Square(string color, double length) : base(color, length) { }
        public override double GetArea()
        {
            return length * length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {GetArea()}");
        }
    }

    public class Circle : Shape
    {
        public Circle(string color, double length) : base(color, length) { }

        public override double GetArea()
        {
            return Math.PI * length * length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {GetArea()}");
        }
    }
}