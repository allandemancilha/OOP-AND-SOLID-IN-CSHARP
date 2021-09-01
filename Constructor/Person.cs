namespace Constructor
{
    public class Person
    {
        //Fields
        public string FirstName;
        public int Age;
        public string Gender;

        /* SE NENHUM VALOR FOR ATRIBUÍDO QUANDO O OBJETO FOR INSTANCIADO, O VA-
           LOR PASSADO SERÁ O VALOR PADRÃO DE CADA TIPO, EXEMPLO:
           
           String = null
           Int = 0

           HELLO, MY NAME IS _______, I'M 0 YEARS OLD AND MY GENDER IS ________.
        */
        public Person()
        {

        }

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
