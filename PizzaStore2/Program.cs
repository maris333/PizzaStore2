using System;

public interface IPizza 
{
    void BuyPizza();
}

public abstract class PizzaCreator
{
    public abstract IPizza CreatePizza();
}

public class MargheritaPizzaCreator : PizzaCreator
{
    public override IPizza CreatePizza()
    {
        return new MargheritaPizza();
    }
}

internal class MargheritaPizza : IPizza
{
    public void BuyPizza()
    {
        Console.WriteLine("Margherita pizza sold.");
    }
}

public class PepperoniPizzaCreator : PizzaCreator
{
    public override IPizza CreatePizza()
    {
        return new PepperoniPizza();
    }
}

internal class PepperoniPizza : IPizza
{
    public void BuyPizza()
    {
        Console.WriteLine("Pepperoni pizza sold.");
    }
}

public class PizzaManager
{
    public void BuyPizza()
    {
        Console.WriteLine("Choose margherita or pepperoni pizza:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "margherita":
                PizzaCreator margheritaCreator = new MargheritaPizzaCreator();
                IPizza margheritaPizza = margheritaCreator.CreatePizza();
                margheritaPizza.BuyPizza();
                break;
            case "pepperoni":
                PizzaCreator pepperoniCreator = new PepperoniPizzaCreator();
                IPizza pepperoniPizza = pepperoniCreator.CreatePizza();
                pepperoniPizza.BuyPizza();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                Environment.Exit(0);
                break;
        }
    }

    class Program
    {
        public static void Main()
        {
            PizzaManager pizzaManager = new PizzaManager();
            pizzaManager.BuyPizza();
        }
    }
}
