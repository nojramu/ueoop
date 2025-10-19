namespace ConsoleApp
{
    public abstract class Canidae
    {
        public abstract void MakeSound();
    }

    public class Dog : Canidae
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}