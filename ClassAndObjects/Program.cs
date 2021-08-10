using System;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.FirstName = "Allan";
            personOne.Age = 23;
            personOne.Gender = "Male";
         
            System.Console.WriteLine($"HELLO, MY NAME IS {personOne.FirstName}, I'M {personOne.Age} YEARS OLD AND MY GENDER IS {personOne.Gender}.");

            Person personTwo = new Person {
                FirstName = "Priscila",
                Age = 22,
                Gender =  "Female"
            };

            System.Console.WriteLine($"HELLO, MY NAME IS {personTwo.FirstName}, I'M {personTwo.Age} YEARS OLD AND MY GENDER IS {personTwo.Gender}.");

            Console.ReadLine();
        }
    }
}
