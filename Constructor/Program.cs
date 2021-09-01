using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.FirstName = "Allan";
            personOne.Age = 23;
            personOne.Gender = "Male";

            personOne.Introduce();
         
            Person personTwo = new Person {
                FirstName = "Priscila",
                Age = 22,
                Gender =  "Female"
            };
            
            personTwo.Introduce();

            Console.ReadLine();
        }
    }
}
