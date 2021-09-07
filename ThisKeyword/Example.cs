namespace ThisKeyword
{
    public class Example
    {
        public string Name { get; set; }

        public Example(string name)
        {
            this.Name = name;

            // PASSANDO A INSTÂNCIA this COMO PARÂMETRO.
            Test test = new Test(this);

            // A INSTÂNCIA Test AGORA POSSUI O MESMO NOME DA INSTÂNCIA Example.
            System.Console.WriteLine(test.Name);
        }    
    }
}
