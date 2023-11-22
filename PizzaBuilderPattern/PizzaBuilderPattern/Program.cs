using PizzaBuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        var cook = new Cook();

        var margheritaBuilder = new MargheritaPizzaBuilder();
        cook.SetPizzaBuilder(margheritaBuilder);
        cook.ConstructPizza();
        Console.WriteLine(cook.GetPizza());

        var pepperoniBuilder = new PepperoniPizzaBuilder();
        cook.SetPizzaBuilder(pepperoniBuilder);
        cook.ConstructPizza();
        Console.WriteLine(cook.GetPizza());
    }
}
