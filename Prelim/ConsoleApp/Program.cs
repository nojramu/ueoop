using System;
using ConsoleApp;

namespace ConsoleApp
{
    // Main class of the application
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // BankAccount account = new BankAccount();
            // account.Deposit(1500);
            // Console.WriteLine("Balance: " + account.GetBalance());
            // Student student = new Student("John Doe", 20);
            // student.ShowName();
            // student.DisplayStudentName();
            // Console.WriteLine(student.name);
            Feline myAnimal = new Cat();
            myAnimal.Speak(); // Output: Meow
        }
    }
}