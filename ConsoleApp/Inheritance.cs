namespace ConsoleApp
{
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Car : Vehicle
    {
        public void PlayMusic()
        {
            Console.WriteLine("Playing music...");
        }
    }
}