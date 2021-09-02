namespace ThisKeyword
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
    }

    public Employee(string FirstName, string Email)
    {
        /* A PALAVRA-CHAVE this REPRESENTA UMA INSTÂNCIA DA CLASSE
           E DE SEUS USOS É EVITAR AMBIGUIDADES ENTRE OS NOMES DAS   
           PROPRIEDADES DA CLASSE E DOS PARÂMETROS.     
        */
        
        this.FirstName = FirstName;
        this.Email = Email;
    }

}
