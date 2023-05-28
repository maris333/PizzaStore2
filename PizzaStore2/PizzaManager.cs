namespace PizzaStore2
{
    internal class PizzaManager
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
    }
}