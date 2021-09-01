namespace Constructor
{
    public class Person
    {
        //Fields
        public string FirstName;
        public int Age;
        public string Gender;

        public void Introduce ()
        {
            System.Console.WriteLine($"HELLO, MY NAME IS {FirstName}, I'M {Age} YEARS OLD AND MY GENDER IS {Gender}.");
        }

    }
}
