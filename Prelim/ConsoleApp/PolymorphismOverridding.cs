namespace ConsoleApp
{
    public class Feline
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Cat : Feline
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

}