using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            
            personOne.Introduce();

            Console.ReadLine();
        }
    }
}
