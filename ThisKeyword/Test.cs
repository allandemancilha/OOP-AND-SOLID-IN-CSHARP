namespace ThisKeyword
{
    public class Test
    {
        public string Name { get; set; }

        public Test(Example example)
        {
            // USA O NOME DA INSTÂNCIA Example.
            this.Name = example.Name;           
        }      
    }
}