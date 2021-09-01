namespace Constructor
{
    public class Person
    {
        //Fields
        public string FirstName;
        public int Age;
        public string Gender;

        public Person(string firstName, int age, string gender)
        {
            FirstName = firstName;
            Age = age;
            Gender = gender;
        }

        public void Introduce ()
        {
            System.Console.WriteLine($"HELLO, MY NAME IS {FirstName}, I'M {Age} YEARS OLD AND MY GENDER IS {Gender}.");
        }

    }
}
