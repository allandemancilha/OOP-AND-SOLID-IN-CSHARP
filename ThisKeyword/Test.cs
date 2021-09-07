namespace ThisKeyword
{
    public class Test
    {
        public string Name { get; set; }

        public Test(Example example)
        {
            this.Name = example.Name;           
        }      
    }
}