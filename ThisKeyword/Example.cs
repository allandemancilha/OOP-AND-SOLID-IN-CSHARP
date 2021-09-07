namespace ThisKeyword
{
    public class Example
    {
        public string Name { get; set; }

        public Example(string name)
        {
            this.Name = name;

            Test test = new Test(this);

            System.Console.WriteLine(test.Name);
        }    
    }
}
