using SliceOfFun;

class Program
{
    public static void Main(string[] args)
    {
        Employee etem = new Employee(
            name: "Etem",
            age: 27,
            gender: "Male",
            nationality: "Turkish",
            isCitizen: true
            );
        UncleEtemPizza uncleEtemPizza = new UncleEtemPizza(new Owner(etem));
        
        Console.WriteLine( uncleEtemPizza );
    }
}