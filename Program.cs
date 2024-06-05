using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "Tae";
            john.LastName = "Albert";
            john.Introduce();

            Classes.Math.Calculator calculator = new Classes.Math.Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

        }
    }
}
