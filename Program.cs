namespace Properties;



class Program
{
    static void Main(string[] args)
    {
       
        {
            var person = new Person(new DateTime(1991, 1, 1));
            
            Console.WriteLine(person.Age);
        }
        
    }
}  

