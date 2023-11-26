using SliceOfFun;
using static SliceOfFun.PizzaStore;

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
        PizzaStore a = PizzaStoreFactory.CreatePizzaStore(PizzaStoreType.SNAPizza, Location.Downtown, new Owner(etem));
        
        Console.WriteLine(a.IsFranchiseStore);
    }
}