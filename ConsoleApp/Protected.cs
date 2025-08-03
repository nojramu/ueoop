namespace ConsoleApp
{
    public class Person
    {
        protected string name;
        protected int age;
        public Person(string personName)
        {
            name = personName;
            age = 0;
        }
        public void ShowName()
        {
            Console.WriteLine("Name: " + name);
        }
    }
    public class Student : Person
    {
        public Student(string studentName, int studentAge) : base(studentName)
        {
            age = studentAge;
        }
        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
        public void DisplayStudentName()
        {
            Console.WriteLine("Student Name: " + name);
        }
    }
}